﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace YetAnotherGarminConnectClient
{
    public static class URLs
    {
        public static string GARMIN_DOMAIN = "garmin.com";

        public static string GARMIN_API_CONSUMER_KEYS =
            "https://github.com/lswiderski/yet-another-garmin-connect-client/raw/main/oauth_consumer.json";

        public static string OAUTH_EXCHANGE_URL =>
            $"https://connectapi.{GARMIN_DOMAIN}/oauth-service/oauth/exchange/user/2.0";

        public static string OAUTH1_URL(string ticket) =>
            $"https://connectapi.{GARMIN_DOMAIN}/oauth-service/oauth/preauthorized?ticket={ticket}&login-url=https://sso.{GARMIN_DOMAIN}/sso/embed&accepts-mfa-tokens=true";

        public static string ORIGIN => $"https://sso.{GARMIN_DOMAIN}";
        public static string REFERER => $"https://sso.{GARMIN_DOMAIN}/sso/signin";
        public static string SSO_SIGNIN_URL => $"https://sso.{GARMIN_DOMAIN}/sso/signin";
        public static string SSO_EMBED_URL => $"https://sso.{GARMIN_DOMAIN}/sso/embed";
        public static string UPLOAD_URL => $"https://connectapi.{GARMIN_DOMAIN}/upload-service/upload";
        public static string SSO_ENTER_MFA_URL => $"https://sso.{GARMIN_DOMAIN}/sso/verifyMFA/loginEnterMfaCode";
    }
}