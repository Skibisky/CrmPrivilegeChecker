using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Crm.Sdk.Messages;
using System.Text.RegularExpressions;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;

namespace CrmPrivilegeChecker {
	public partial class CrmPrivilegeCheckerControl : PluginControlBase {

		Entity user;
		Entity priv;

		public CrmPrivilegeCheckerControl() {
			InitializeComponent();
			tbError.Text = "System.ServiceModel.FaultException`1[Microsoft.Xrm.Sdk.OrganizationServiceFault]: Principal user (Id=35e3ad25-739f-e811-a980-000d3a81e2e0, type=8 , accessMode=4, roleCount=2 ) is missing prvAppendillumina_purchaseorder privilege (Id=a5ff94e8-fe9a-42e7-9366-274226d03a0b)";
			cbRoles.Format += CbRoles_Format;
			cbDepth.Format += CbDepth_Format;
			foreach (var en in Enum.GetValues(typeof(PrivilegeDepth))) {
				cbDepth.Items.Add(en);
			}
			cbDepth.SelectedIndex = cbDepth.Items.Count - 1;
			lbError.Text = "";
			btnAdd.Enabled = false;
		}

		private void CbDepth_Format(object sender, ListControlConvertEventArgs e) {
			e.Value = ((PrivilegeDepth)e.ListItem).ToString();
		}

		private void CbRoles_Format(object sender, ListControlConvertEventArgs e) {
			var itemEntity = e.ListItem as Entity;
			if (itemEntity?.LogicalName == "role") {
				e.Value = itemEntity.GetAttributeValue<string>("name");
			}
			else
				e.Value = e.ListItem?.ToString();
		}

		private void error(string msg) {
			this.Invoke((MethodInvoker)delegate {
				lbError.Text = msg;
			});
		}

		private void btnCheck_Click(object sender, EventArgs e) {
			var text = tbError.Text;
			if (string.IsNullOrWhiteSpace(text))
				return;

			btnCheck.Enabled = false;
			WorkAsyncInfo info = null;
			info = new WorkAsyncInfo("Getting Data", (a) => {
				try {
					Regex reg = new Regex("user \\(Id=(.*?),");
					var match = reg.Match(text);
					var idstr = match.Groups[match.Groups.Count - 1].Value;
					if (string.IsNullOrWhiteSpace(idstr)) {
						throw new InvalidOperationException("No user ID found.");
					}
					Guid userId = new Guid(idstr);

					reg = new Regex("privilege \\(Id=(.*?)\\)");
					match = reg.Match(text);
					idstr = match.Groups[match.Groups.Count - 1].Value;
					if (string.IsNullOrWhiteSpace(idstr)) {
						throw new InvalidOperationException("No privilege ID found.");
					}
					Guid privId = new Guid(idstr);

					user = this.ConnectionDetail.ServiceClient.Retrieve("systemuser", userId, new Microsoft.Xrm.Sdk.Query.ColumnSet(true));
					
					this.Invoke((MethodInvoker)delegate {
						lbWho.Text = "Who: " + user.GetAttributeValue<string>("fullname") + ": " + user.GetAttributeValue<string>("internalemailaddress");
					});

					var userRoles = this.ConnectionDetail.ServiceClient.RetrieveMultiple(new QueryExpression("systemuserroles") {
						ColumnSet = new ColumnSet(true),
						Criteria = new FilterExpression(LogicalOperator.And) {
							Conditions = {
						new ConditionExpression("systemuserid", ConditionOperator.Equal, userId),
					}
						}
					}).Entities;

					if (userRoles.Count == 0) {
						throw new InvalidOperationException("User has no roles.");
					}

					priv = this.ConnectionDetail.ServiceClient.Retrieve("privilege", privId, new Microsoft.Xrm.Sdk.Query.ColumnSet(true));

					this.Invoke((MethodInvoker)delegate {
						lbWhat.Text = "What: " + priv.GetAttributeValue<string>("name");
						cbRoles.Items.Clear();
					});

					var roles = new List<Entity>();
					foreach (var ur in userRoles) {
						var role = this.ConnectionDetail.ServiceClient.Retrieve("role", ur.GetAttributeValue<Guid>("roleid"), new ColumnSet(true));
						this.Invoke((MethodInvoker)delegate {
							cbRoles.Items.Add(role);
						});
					}
					this.Invoke((MethodInvoker)delegate {
						cbRoles.SelectedIndex = 0;
						btnAdd.Enabled = true;
					});
				}
				catch (Exception ex) {
					error(ex.GetType() + ":" + Environment.NewLine + ex.Message);
					throw;
				}
				finally {
					this.Invoke((MethodInvoker)delegate {
						btnCheck.Enabled = true;
					});
				}
			});
			this.WorkAsync(info);
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			btnAdd.Enabled = false;
			var depth = (PrivilegeDepth)cbDepth.SelectedItem;
			var role = (cbRoles.SelectedItem as Entity);
			this.WorkAsync(new WorkAsyncInfo("Adding privilege", (a) => {
				try {
					var resp = this.ConnectionDetail.ServiceClient.Execute(new AddPrivilegesRoleRequest() {
						Privileges = new RolePrivilege[] {
							new RolePrivilege(depth, priv.Id, role.GetAttributeValue<EntityReference>("businessunitid").Id),
						},
						RoleId = role.Id
					}) as AddPrivilegesRoleResponse;
				}
				catch (Exception ex) {
					error(ex.GetType() + ":" + Environment.NewLine + ex.Message);
					throw;
				}
				finally {
					this.Invoke((MethodInvoker)delegate {
						btnAdd.Enabled = true;
					});
				}
			}));
		}
	}
}
