using System;
using System.ServiceProcess;
using System.ServiceModel;
using System.ServiceModel.Description;
using Anticafe_4._0_ModelView;

namespace DBServise
{
	public partial class DBService : ServiceBase
	{
		private ServiceHost service_host = null;

		public DBService()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			if (service_host != null) service_host.Close();

			string address_HTTP = "http://localhost:1/DBServise";
			string address_TCP = "net.tcp://localhost:2/DBServise";

			Uri[] address_base = { new Uri(address_HTTP), new Uri(address_TCP) };
			service_host = new ServiceHost(typeof(WorkDB), address_base);

			ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
			service_host.Description.Behaviors.Add(behavior);

			BasicHttpBinding binding_http = new BasicHttpBinding();
			service_host.AddServiceEndpoint(typeof(IWorkDB), binding_http, address_HTTP);
			service_host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

			NetTcpBinding binding_tcp = new NetTcpBinding();
			binding_tcp.Security.Mode = SecurityMode.Transport;
			binding_tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
			binding_tcp.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
			binding_tcp.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
			service_host.AddServiceEndpoint(typeof(IWorkDB), binding_tcp, address_TCP);
			service_host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");

			service_host.Open();
		}

		protected override void OnStop()
		{
			if (service_host != null)
			{
				service_host.Close();
				service_host = null;
			}
		}
	}
}
