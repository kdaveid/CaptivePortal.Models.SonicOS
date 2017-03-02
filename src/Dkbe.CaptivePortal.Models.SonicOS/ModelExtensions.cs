// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    /// <summary>
    /// Helper methods to create SNWL responses.
    /// </summary>
    public static class ResponseHelper
    {
        public static class WebServerStatus
        {
            public const int WEBSERVER_STATUS_OK = 0;
            public const int WEBSERVER_STATUS_DBDOWN = 1;
            public const int WEBSERVER_STATUS_CONFIGERROR = 2;
            public const int WEBSERVER_STATUS_INTERNALERROR = 255;

            public static SNWLWebServerStatusReply Ok() => new SNWLWebServerStatusReply { ServerStatus = WEBSERVER_STATUS_OK };

            public static SNWLWebServerStatusReply DbDown() => new SNWLWebServerStatusReply { ServerStatus = WEBSERVER_STATUS_DBDOWN };

            public static SNWLWebServerStatusReply ConfigError() => new SNWLWebServerStatusReply { ServerStatus = WEBSERVER_STATUS_CONFIGERROR };

            public static SNWLWebServerStatusReply InternalError() => new SNWLWebServerStatusReply { ServerStatus = WEBSERVER_STATUS_INTERNALERROR };
        }

        public static class Logoff
        {
            public const int LOGOFF_SUCCEEDED = 150;
            public const int INVALID_HMAC = 251;
            public const int INVALID_SESSION_ID = 253;
            public const int INVALID_OR_MISSING_PARAM = 254;
            public const int INTERNAL_ERROR = 255;

            public static SNWLLogoffReply IdleTimeoutReceived() => new SNWLLogoffReply { ResponseCode = RequestHelper.Logoff.LOGOFF_EVENT_IDLE_TIMEOUT_EXPIRED, ReplyMessage = "ok" };

            public static SNWLLogoffReplyXMLResponse LogoffSucceededResponse() =>
                new SNWLLogoffReplyXMLResponse { LogoffReply = new SNWLLogoffReply { ResponseCode = LOGOFF_SUCCEEDED, ReplyMessage = "Logoff succeeded" } };

            public static SNWLLogoffReplyXMLResponse InvalidHMACResponse() =>
                new SNWLLogoffReplyXMLResponse { LogoffReply = new SNWLLogoffReply { ResponseCode = INVALID_HMAC, ReplyMessage = "Msg. Auth failed -- Invalid HMAC" } };

            public static SNWLLogoffReplyXMLResponse InvalidSessionIDResponse() =>
                new SNWLLogoffReplyXMLResponse { LogoffReply = new SNWLLogoffReply { ResponseCode = INVALID_SESSION_ID, ReplyMessage = "Invalid session ID" } };

            public static SNWLLogoffReplyXMLResponse InvalidOrMissingCGIParamResponse() =>
                new SNWLLogoffReplyXMLResponse { LogoffReply = new SNWLLogoffReply { ResponseCode = INVALID_OR_MISSING_PARAM, ReplyMessage = "Invalid or missing CGI parameter" } };

            public static SNWLLogoffReplyXMLResponse InternalErrorResponse() =>
                new SNWLLogoffReplyXMLResponse { LogoffReply = new SNWLLogoffReply { ResponseCode = INTERNAL_ERROR, ReplyMessage = "Internal error" } };
        }

        public static class SessionSync
        {
            public const int SESSION_SYNC_SUCCESS = 200;
            public const int SESSION_SYNC_FAIL = 201;
            public const int SESSION_SYNC_INTERNALERROR = 255;

            public static SNWLSessionStateSyncReply Success() => new SNWLSessionStateSyncReply { SessionSync = new SessionStateSyncReply { ResponseCode = SESSION_SYNC_SUCCESS } };
            public static SNWLSessionStateSyncReply Fail() => new SNWLSessionStateSyncReply { SessionSync = new SessionStateSyncReply { ResponseCode = SESSION_SYNC_FAIL } };
            public static SNWLSessionStateSyncReply InternalError() => new SNWLSessionStateSyncReply { SessionSync = new SessionStateSyncReply { ResponseCode = SESSION_SYNC_INTERNALERROR } };
        }


        public static class Login
        {
            public const int LOGIN_SUCCEEDED = 50;
            public const int SESSION_LIMIT_EXCEEDED = 51;
            public const int LOGIN_FAILED = 100;
            public const int INVALID_HMAC = 251;
            public const int INVALID_SESSION_ID = 253;
            public const int INVALID_OR_MISSING_PARAM = 254;
            public const int INTERNAL_ERROR = 255;

            public static SNWLExternalAuthenticationXMLResponse LoginSucceededResponse() =>
                        new SNWLExternalAuthenticationXMLResponse { AuthenticationReply = new SNWLExternalAuthenticationReply { ResponseCode = LOGIN_SUCCEEDED, ReplyMessage = "Login succeeded" } };

            public static SNWLExternalAuthenticationXMLResponse SessionLimitExceededResponse() =>
                new SNWLExternalAuthenticationXMLResponse { AuthenticationReply = new SNWLExternalAuthenticationReply { ResponseCode = SESSION_LIMIT_EXCEEDED, ReplyMessage = "Session limit exceeded" } };

            public static SNWLExternalAuthenticationXMLResponse LoginFailedResponse() =>
                new SNWLExternalAuthenticationXMLResponse { AuthenticationReply = new SNWLExternalAuthenticationReply { ResponseCode = LOGIN_FAILED, ReplyMessage = "Login failed -- access reject" } };

            public static SNWLExternalAuthenticationXMLResponse InvalidHMACResponse() =>
                new SNWLExternalAuthenticationXMLResponse { AuthenticationReply = new SNWLExternalAuthenticationReply { ResponseCode = INVALID_HMAC, ReplyMessage = "Msg. Auth failed -- Invalid HMAC" } };

            public static SNWLExternalAuthenticationXMLResponse InvalidSessionIDResponse() =>
                new SNWLExternalAuthenticationXMLResponse { AuthenticationReply = new SNWLExternalAuthenticationReply { ResponseCode = INVALID_SESSION_ID, ReplyMessage = "Invalid session ID" } };

            public static SNWLExternalAuthenticationXMLResponse InvalidOrMissingCGIParamResponse() =>
                new SNWLExternalAuthenticationXMLResponse { AuthenticationReply = new SNWLExternalAuthenticationReply { ResponseCode = INVALID_OR_MISSING_PARAM, ReplyMessage = "Invalid or missing CGI parameter" } };

            public static SNWLExternalAuthenticationXMLResponse InternalErrorResponse() =>
                new SNWLExternalAuthenticationXMLResponse { AuthenticationReply = new SNWLExternalAuthenticationReply { ResponseCode = INTERNAL_ERROR, ReplyMessage = "Internal error" } };
        }

        public static class UpdateSession
        {
            public const int SESSION_UPDATE_SUCCEEDED = 210;
            public const int SESSION_UPDATE_FAILED = 211;
            public const int INVALID_HMAC = 251;
            public const int INVALID_OR_MISSING_PARAM = 254;
            public const int INTERNAL_ERROR = 255;

            public static SNWLUpdateSessionReplyXMLResponse UpdateSessionSucceededResponse() =>
                new SNWLUpdateSessionReplyXMLResponse { UpdateSessionReply = new UpdateSessionReply { ResponseCode = SESSION_UPDATE_SUCCEEDED, ReplyMessage = "Session Update succeeded" } };

            public static SNWLUpdateSessionReplyXMLResponse UpdateSessionFailedResponse() =>
                new SNWLUpdateSessionReplyXMLResponse { UpdateSessionReply = new UpdateSessionReply { ResponseCode = SESSION_UPDATE_FAILED, ReplyMessage = "Session Update failed" } };

            public static SNWLUpdateSessionReplyXMLResponse InvalidHMACResponse() =>
                new SNWLUpdateSessionReplyXMLResponse { UpdateSessionReply = new UpdateSessionReply { ResponseCode = INVALID_HMAC, ReplyMessage = "Msg. Auth failed -- Invalid HMAC" } };

            public static SNWLUpdateSessionReplyXMLResponse InvalidOrMissingCGIParamResponse() =>
                new SNWLUpdateSessionReplyXMLResponse { UpdateSessionReply = new UpdateSessionReply { ResponseCode = INVALID_OR_MISSING_PARAM, ReplyMessage = "Invalid or missing CGI parameter" } };

            public static SNWLUpdateSessionReplyXMLResponse InternalErrorResponse() =>
                new SNWLUpdateSessionReplyXMLResponse { UpdateSessionReply = new UpdateSessionReply { ResponseCode = INTERNAL_ERROR, ReplyMessage = "Internal error" } };

        }
    }

    /// <summary>
    /// Helper methods to create requests for sending to SNWL.
    /// </summary>
    public static class RequestHelper
    {
        public static class Logoff
        {
            public const int LOGOFF_EVENT_MANUAL_GUESTLOGOFF = 1;
            public const int LOGOFF_EVENT_ADMIN_GUESTLOGOFF = 2;
            public const int LOGOFF_EVENT_SESSION_EXPIRED = 3;
            public const int LOGOFF_EVENT_IDLE_TIMEOUT_EXPIRED = 4;

            /// 1       Guest logged out manually
            /// 2       Admin logged off the specified guest
            /// 3       Guest session expired
            /// 4       Guest idle timeout expired
            public static SNWLLogoffRequest ManualGuestLogoff(string SessionId) => new SNWLLogoffRequest { sessId = SessionId, eventId = LOGOFF_EVENT_MANUAL_GUESTLOGOFF };
            public static SNWLLogoffRequest AdminLogoff(string SessionId) => new SNWLLogoffRequest { sessId = SessionId, eventId = LOGOFF_EVENT_ADMIN_GUESTLOGOFF };
            public static SNWLLogoffRequest SessionExpired(string SessionId) => new SNWLLogoffRequest { sessId = SessionId, eventId = LOGOFF_EVENT_SESSION_EXPIRED };
            public static SNWLLogoffRequest IdleTimeout(string SessionId) => new SNWLLogoffRequest { sessId = SessionId, eventId = LOGOFF_EVENT_IDLE_TIMEOUT_EXPIRED };
            public static SNWLLogoffRequest CreateByType(string sessionId, int snwlLogoffType)
            {
                switch (snwlLogoffType)
                {
                    case LOGOFF_EVENT_ADMIN_GUESTLOGOFF:
                        return AdminLogoff(sessionId);
                    case LOGOFF_EVENT_SESSION_EXPIRED:
                        return SessionExpired(sessionId);
                    case LOGOFF_EVENT_IDLE_TIMEOUT_EXPIRED:
                        return IdleTimeout(sessionId);
                    case LOGOFF_EVENT_MANUAL_GUESTLOGOFF:
                    default:
                        return ManualGuestLogoff(sessionId);
                }
            }
        }

    }
}