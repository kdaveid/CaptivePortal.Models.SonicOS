using Xunit;
using System.IO;
using Dkbe.CaptivePortal.Models.SonicOS;
using System.Xml.Serialization;
using static Dkbe.CaptivePortal.UnitTests.SerializationSamples;
using System.Net;

namespace Dkbe.CaptivePortal.UnitTests
{
    public class SNWLResponseDeserializationTests
    {
        [Fact]
        public void CanDeserialize_SessionSyncReplyBody()
        {
            // Arrange
            SNWLSessionSyncRequest sessions;
            var serializer = new XmlSerializer(typeof(SNWLSessionSyncRequest));

            // Act
            using (var reader = new StringReader(SAMPLE_SESSION_SYNC_REPLY_BODY))
            {
                sessions = (SNWLSessionSyncRequest)serializer.Deserialize(reader);
            }

            // Assert
            Assert.IsType<SNWLSessionSyncRequest>(sessions);
            Assert.Equal(sessions.SessionSync.SessionCount, 2);
            Assert.Equal(sessions.SessionSync.SessionList[0].ID, "71132b0ae76285f0741b7906a5a89dfe");
            Assert.Equal(sessions.SessionSync.SessionList[0].Idle, 1484941179);
            Assert.Equal(sessions.SessionSync.SessionList[1].IP, "10.1.29.22");
        }

        [Fact]
        public void CanDeserialize_FormEncoded_SessionSyncReply()
        {
            // Arrange
            SNWLSessionSyncRequest sessions;
            var sessionListString = "sessionList=";
            var serializer = new XmlSerializer(typeof(SNWLSessionSyncRequest));

            // Act
            var decodedString = WebUtility.UrlDecode(SAMPLE_FORM_ENCODED_SESSION_SYNC_REPLY);
            var content = decodedString.Substring(sessionListString.Length);

            using (var reader = new StringReader(content))
            {
                
                sessions = (SNWLSessionSyncRequest)serializer.Deserialize(reader);

            }

            // Assert
            Assert.IsType<SNWLSessionSyncRequest>(sessions);
            Assert.Equal(2, sessions.SessionSync.SessionCount);
            Assert.Equal("71132b0ae76285f0741b7906a5a89dfe", sessions.SessionSync.SessionList[0].ID);
            Assert.Equal(1484940334, sessions.SessionSync.SessionList[0].Idle);
            Assert.Equal("10.1.29.22", sessions.SessionSync.SessionList[1].IP);
        }

        [Fact]
        public void CanDeserialize_UpdateSessionReply()
        {
            // Arrange
            SNWLUpdateSessionReplyXMLResponse updateSessionReply;
            var serializer = new XmlSerializer(typeof(SNWLUpdateSessionReplyXMLResponse));

            // Act
            using (var sr = new StringReader(SAMPLE_SESSION_UPDATE_SUCCESS))
            {
                updateSessionReply = (SNWLUpdateSessionReplyXMLResponse)serializer.Deserialize(sr);
            }

            // Assert
            Assert.IsType<SNWLUpdateSessionReplyXMLResponse>(updateSessionReply);
            Assert.NotNull(updateSessionReply.UpdateSessionReply);
            Assert.IsType<UpdateSessionReply>(updateSessionReply.UpdateSessionReply);
            Assert.Equal(updateSessionReply.UpdateSessionReply.ResponseCode, 210);
        }

        [Fact]
        public void CanDeserialize_ExternalAuthReply()
        {
            // Arrange
            SNWLExternalAuthenticationXMLResponse authResponse;
            var serializer = new XmlSerializer(typeof(SNWLExternalAuthenticationXMLResponse));

            // Act
            using (var reader = new StringReader(SAMPLE_EXTERNAL_AUTH_REPLY))
            {
                authResponse = (SNWLExternalAuthenticationXMLResponse)serializer.Deserialize(reader);
            }

            // Assert
            Assert.IsType<SNWLExternalAuthenticationXMLResponse>(authResponse);
            Assert.Equal(authResponse.AuthenticationReply.ResponseCode, 50);
        }

    }
}
