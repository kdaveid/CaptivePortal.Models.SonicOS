using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dkbe.CaptivePortal.UnitTests
{
    public static class SerializationSamples
    {
        public const string SAMPLE_SESSION_SYNC_REPLY_BODY =
                @"<?xml version=""1.0""?>
                    <SonicWALLAccessGatewayParam xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:noNamespaceSchemaLocation=""http://www.sonicwall.com/SonicWALLAccessGatewayParam.xsd"">
                      <SessionSync>
                        <SessionCount>2</SessionCount>
                        <SessionList>
                          <Session>
                            <Ssid></Ssid>
                            <ID>71132b0ae76285f0741b7906a5a89dfe</ID>
                            <UserName>Guest - Auth Bypassed</UserName>
                            <IP>10.1.29.6</IP>
                            <MAC>18:f6:43:90:4d:6d</MAC>
                            <Idle>1484941179</Idle>
                            <SessionRemaining>0</SessionRemaining>
                            <BaseMgmtUrl>https://10.10.10.1:4043/</BaseMgmtUrl>
                            <RxBytes>118578</RxBytes>
                            <TxBytes>58593</TxBytes>
                          </Session>
                          <Session>
                            <Ssid></Ssid>
                            <ID>54b516e0e5b7b43959d6edbd26279b22</ID>
                            <UserName>test_a8667f145998</UserName>
                            <IP>10.1.29.22</IP>
                            <MAC>a8:66:7f:14:59:98</MAC>
                            <Idle>959</Idle>
                            <SessionRemaining>0</SessionRemaining>
                            <BaseMgmtUrl>https://10.10.10.1:4043/</BaseMgmtUrl>
                            <RxBytes>4258752</RxBytes>
                            <TxBytes>711387</TxBytes>
                          </Session>
                        </SessionList>
                      </SessionSync>
                    </SonicWALLAccessGatewayParam>";


        public const string SAMPLE_FORM_ENCODED_SESSION_SYNC_REPLY =
             @"sessionList=<%3Fxml%20version=""1.0""%3F><SonicWALLAccessGatewayParam%20xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""%20xsi:noNamespaceSchemaLocation=""http://www.sonicwall.com/SonicWALLAccessGatewayParam.xsd""><SessionSync><SessionCount>2</SessionCount><SessionList><Session><Ssid></Ssid><ID>71132b0ae76285f0741b7906a5a89dfe</ID><UserName>Guest%20-%20Auth%20Bypassed</UserName><IP>10.1.29.6</IP><MAC>18:f6:43:90:4d:6d</MAC><Idle>1484940334</Idle><SessionRemaining>0</SessionRemaining><BaseMgmtUrl>https://10.10.10.1:4043/</BaseMgmtUrl><RxBytes>75889</RxBytes><TxBytes>33772</TxBytes></Session><Session><Ssid></Ssid><ID>54b516e0e5b7b43959d6edbd26279b22</ID><UserName>test_a8667f145998</UserName><IP>10.1.29.22</IP><MAC>a8:66:7f:14:59:98</MAC><Idle>114</Idle><SessionRemaining>0</SessionRemaining><BaseMgmtUrl>https://10.10.10.1:4043/</BaseMgmtUrl><RxBytes>3444167</RxBytes><TxBytes>359307</TxBytes></Session></SessionList></SessionSync></SonicWALLAccessGatewayParam>";

        public const string SAMPLE_EXTERNAL_AUTH_REPLY =
             @"<?xml version=""1.0"" encoding=""UTF-8""?> <SonicWALLAccessGatewayParam
                            xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:noNamespaceSchemaLocation=""http://www.sonicwall.com/ SonicWALLAccessGatewayParam.xsd""> <AuthenticationReply>
                            <ResponseCode>50</ResponseCode>
                            <ReplyMessage>Login succeeded</ReplyMessage> </AuthenticationReply>
                            </SonicWALLAccessGatewayParam>";

        public const string SAMPLE_SESSION_UPDATE_SUCCESS =
            @"<?xml version=""1.0"" encoding=""UTF-8""?>
                        <SonicWALLAccessGatewayParam xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:noNamespaceSchemaLocation=""http://www.sonicwall.com/SonicWALLAccessGatewayParam.xsd"">
	                        <UpdateSessionReply>
		                        <ResponseCode>210</ResponseCode>
	                        </UpdateSessionReply>
                        </SonicWALLAccessGatewayParam>";


        public const string SAMPLE_SESSION_UPDATE_FAILURE = 
            @"<?xml version=""1.0"" encoding=""UTF-8""?>
                        <SonicWALLAccessGatewayParam xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:noNamespaceSchemaLocation=""http://www.sonicwall.com/SonicWALLAccessGatewayParam.xsd"">
	                        <UpdateSessionReply>
		                        <ResponseCode>254</ResponseCode>
		                        <ReplyMessage>Invalid or missing parameter</ReplyMessage>
	                        </UpdateSessionReply>
                        </SonicWALLAccessGatewayParam>";
    }
}