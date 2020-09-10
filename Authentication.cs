#region Author
/*
     
     Jones St. Lewis Cropper (caLLow)
     
     Another caLLowCreation
     
     Visit us on Google+ and other social media outlets @caLLowCreation
     
     Thanks for using our product.
     
     Send questions/comments/concerns/requests to 
      e-mail: caLLowCreation@gmail.com
      subject: TwitchPubSubAPI
     
*/
#endregion

using System;
using System.Linq;
using System.Collections.Generic;

namespace TwitchHelixAPI
{
    public static class Authentication
    {
        public const string BASE_URL = "https://api.twitch.tv/helix";

        static string GetEndpointUrl(string url)
        {
            string baseUrl = url.Split('?')[0];
            return baseUrl;
        }

        public static bool HasScope(string scope)
        {
            foreach (var item in Helix.ScopeMap())
            {
                if (item.Key == scope) return true;
            }
            return false;
        }

        public static string GetAssociatedScope(string url)
        {
            string key = GetEndpointUrl(url);
            foreach (var item in Helix.ScopeMap())
            {
                if (item.Key == key) return item.Value;
            }

            return string.Empty;
        }

        public static class Endpoints
        {
            public const string START_COMMERCIAL = BASE_URL + "/channels/commercial";
            public const string GET_EXTENSION_ANALYTICS = BASE_URL + "/analytics/extensions";
            public const string GET_CHEERMOTES = BASE_URL + "/bits/cheermotes";
            public const string GET_BITS_LEADERBOARD = BASE_URL + "/bits/leaderboard";
            public const string GET_GAME_ANALYTICS = BASE_URL + "/analytics/games";
            public const string GET_EXTENSION_TRANSACTIONS = BASE_URL + "/extensions/transactions"; // in docs helix/extensions/transactions
            public const string CREATE_CLIP = BASE_URL + "/clips";
            public const string GET_CLIPS = BASE_URL + "/clips";
            public const string CREATE_ENTITLEMENT_GRANTS_UPLOAD_URL = BASE_URL + "/entitlements/upload";
            public const string GET_CODE_STATUS = BASE_URL + "/entitlements/codes";

            public const string REDEEM_CODE = BASE_URL + "/entitlements/code";
            public const string GET_TOP_GAMES = BASE_URL + "/games/top";
            public const string GET_GAMES = BASE_URL + "/games";
            public const string CHECK_AUTO_MOD_STATUS = BASE_URL + "/moderation/enforcements/status";
            public const string GET_BANNED_USERS = BASE_URL + "/moderation/banned";
            public const string GET_BANNED_EVENTS = BASE_URL + "/moderation/banned/events";
            public const string GET_MODERATORS = BASE_URL + "/moderation/moderators";
            public const string GET_MODERATOR_EVENTS = BASE_URL + "/moderation/moderators/events";
            public const string SEARCH_CATEGORIES = BASE_URL + "/search/categories ";
            public const string SEARCH_CHANNELS = BASE_URL + "/search/channels"; // in docs helix/search/channels

            public const string GET_STREAM_KEY = BASE_URL + "/streams/key";
            public const string GET_STREAMS = BASE_URL + "/streams";
            public const string CREATE_STREAM_MARKER = BASE_URL + "/streams/markers";
            public const string GET_STREAM_MARKERS = BASE_URL + "/streams/markers";
            public const string GET_CHANNEL_INFORMATION = BASE_URL + "/channels";
            public const string MODIFY_CHANNEL_INFORMATION = BASE_URL + "/channels"; // PATCH
            public const string GET_BROADCASTER_SUBSCRIPTIONS = BASE_URL + "/subscriptions";
            public const string GET_ALL_STREAM_TAGS = BASE_URL + "/tags/streams";
            public const string GET_STREAM_TAGS = BASE_URL + "/streams/tags";
            public const string REPLACE_STREAM_TAGS = BASE_URL + "/streams/tags";

            public const string CREATE_USER_FOLLOWS = BASE_URL + "/users/follows";
            public const string DELETE_USER_FOLLOWS = BASE_URL + "/users/follows";
            public const string GET_USERS = BASE_URL + "/users";
            public const string GET_USERS_FOLLOWS = BASE_URL + "/users/follows";
            public const string UPDATE_USER = BASE_URL + "/users";
            public const string GET_USER_EXTENSIONS = BASE_URL + "/users/extensions/list";
            public const string GET_USER_ACTIVE_EXTENSIONS = BASE_URL + "/users/extensions";
            public const string UPDATE_USER_EXTENSIONS = BASE_URL + "/users/extensions";
            public const string GET_VIDEOS = BASE_URL + "/videos";
            public const string GET_WEBHOOK_SUBSCRIPTIONS = BASE_URL + "/webhooks/subscriptions";

            public const string GET_HYPE_TRAIN_EVENTS = BASE_URL + "/hypetrain/events";

            public static string GetEndpoint(string url)
            {
                string baseUrl = GetEndpointUrl(url);
                return baseUrl.Substring(BASE_URL.Length);
            }

        }

        /// <summary>
        /// When you request authorization from users, the URL scope parameter allows you to specify which permissions your app requires
        /// </summary>
        public static class Scopes
        {
            /// <summary>
            /// These scopes apply to both OAuth and OIDC token requests. You can specify any or all of these scopes
            /// </summary>
            public static class NewTwitchAPI
            {
                /// <summary>
                /// View analytics data for your extensions.
                /// </summary>
                public const string ANALYTICS_READ_EXTENSIONS = "analytics:read:extensions";
                /// <summary>
                /// View analytics data for your games.
                /// </summary>
                public const string ANALYTICS_READ_GAMES = "analytics:read:games";
                /// <summary>
                /// View Bits information for your channel.
                /// </summary>
                public const string BITS_READ = "bits:read";
                /// <summary>
                /// Run commercials on a channel.
                /// </summary>
                public const string CHANNEL_EDIT_COMMERCIAL = "channel:edit:commercial";
                /// <summary>
                /// No description in docs
                /// </summary>
                public const string CHANNEL_READ_HYPE_TRAIN = "channel:read:hype_train";
                /// <summary>
                /// Get a list of all subscribers to your channel and check if a user is subscribed to your channel
                /// </summary>
                public const string CHANNEL_READ_SUBSCRIPTIONS = "channel:read:subscriptions";
                /// <summary>
                /// Manage a clip object.
                /// </summary>
                public const string CLIPS_EDIT = "clips:edit";
                /// <summary>
                /// Manage a user object.
                /// </summary>
                public const string USER_EDIT = "user:edit";
                /// <summary>
                /// Edit your channel’s broadcast configuration, including extension configuration. (This scope implies user:read:broadcast capability.)
                /// </summary>
                public const string USER_EDIT_BROADCAST = "user:edit:broadcast";
                /// <summary>
                /// Edit your follows.
                /// </summary>
                public const string USER_EDIT_FOLLOWS = "user:edit:follows";
                /// <summary>
                /// View your broadcasting configuration, including extension configurations.
                /// </summary>
                public const string USER_READ_BROADCAST = "user:read:broadcast";
                /// <summary>
                /// Read authorized user’s email address.
                /// </summary>
                public const string USER_READ_EMAIL = "user:read:email";
                /// <summary>
                /// Read authorized user’s stream key.
                /// </summary>
                public const string USER_READ_STREAM_KEY = "user:read:stream_key";

                /// <summary>
                /// Not in docs
                /// </summary>
                public const string CHANNEL_READ_STREAM_KEY = "user:read:stream_key";
                /// <summary>
                /// Not in docs
                /// </summary>
                public const string MODERATION_READ = "moderation:read";
            }

            /// <summary>
            /// You can specify any or all of these scopes
            /// </summary>
            public static class TwitchAPIv5
            {
                /// <summary>
                /// Read whether a user is subscribed to your channel.
                /// </summary>
                public const string CHANNEL_CHECK_SUBSCRIPTION = "channel_check_subscription";
                /// <summary>
                /// Trigger commercials on channel.
                /// </summary>
                public const string CHANNEL_COMMERCIAL = "channel_commercial";
                /// <summary>
                /// Write channel metadata (game, status, etc).
                /// </summary>
                public const string CHANNEL_EDITOR = "channel_editor";
                /// <summary>
                /// Add posts and reactions to a channel feed.
                /// </summary>
                public const string CHANNEL_FEED_EDIT = "channel_feed_edit";
                /// <summary>
                /// View a channel feed.
                /// </summary>
                public const string CHANNEL_FEED_READ = "channel_feed_read";
                /// <summary>
                /// Read nonpublic channel information, including email address and stream key.
                /// </summary>
                public const string CHANNEL_READ = "channel_read";
                /// <summary>
                /// Reset a channel’s stream key.
                /// </summary>
                public const string CHANNEL_STREAM = "channel_stream";
                /// <summary>
                /// Read all subscribers to your channel.
                /// </summary>
                public const string CHANNEL_SUBSCRIPTIONS = "channel_subscriptions";
                /// <summary>
                /// (Deprecated — cannot be requested by new clients.) Log into chat and send messages.
                /// </summary>
                public const string CHAT_LOGIN = "chat_login";
                /// <summary>
                /// Manage a user’s collections (of videos).
                /// </summary>
                public const string COLLECTIONS_EDIT = "collections_edit";
                /// <summary>
                /// Manage a user’s communities.
                /// </summary>
                public const string COMMUNITIES_EDIT = "communities_edit";
                /// <summary>
                /// Manage community moderators.
                /// </summary>
                public const string COMMUNITIES_MODERATE = "communities_moderate";
                /// <summary>
                /// Use OpenID Connect authentication.
                /// </summary>
                public const string OPEN_ID = "openid";
                /// <summary>
                /// Turn on/off ignoring a user. Ignoring users means you cannot see them type, receive messages from them, etc.
                /// </summary>
                public const string USER_BLOCKS_EDIT = "user_blocks_edit";
                /// <summary>
                /// Read a user’s list of ignored users.
                /// </summary>
                public const string USER_BLOCKS_READ = "user_blocks_read";
                /// <summary>
                /// Manage a user’s followed channels.
                /// </summary>
                public const string USER_FOLLOWS_EDIT = "user_follows_edit";
                /// <summary>
                /// Read nonpublic user information, like email address.
                /// </summary>
                public const string USER_READ = "user_read";
                /// <summary>
                /// Read a user’s subscriptions.
                /// </summary>
                public const string USER_SUBSCRIPTIONS = "user_subscriptions";
                /// <summary>
                /// Turn on Viewer Heartbeat Service ability to record user data.
                /// </summary>
                public const string VIEWING_ACTIVITY_READ = "viewing_activity_read";
            }

            /// <summary>
            /// Chat and PubSub based scopes
            /// </summary>
            public static class ChatAndPubSub
            {
                /// <summary>
                /// Perform moderation actions in a channel. The user requesting the scope must be a moderator in the channel.
                /// </summary>
                public const string CHANNEL_MODERATE = "channel:moderate";
                /// <summary>
                /// Send live stream chat and rooms messages.
                /// </summary>
                public const string CHAT_EDIT = "chat:edit";
                /// <summary>
                /// View live stream chat and rooms messages.
                /// </summary>
                public const string CHAT_READ = "chat:read";
                /// <summary>
                /// View your whisper messages.
                /// </summary>
                public const string WHISPERS_READ = "whispers:read";
                /// <summary>
                /// Send whisper messages.
                /// </summary>
                public const string WHISPERS_EDIT = "whispers:edit";
                /// <summary>
                /// A custom reward is redeemed in a channel.
                /// </summary>
                public const string CHANNEL_READ_REDEMPTIONS = "channel:read:redemptions";
            }
        }

        public class Helix
        {
            /// <summary>
            /// Mapping of the API endpoints to the required scopes
            /// </summary>
            static (string, string)[] s_ScopeMap = new (string, string)[]
            {
                (Endpoints.START_COMMERCIAL , Scopes.NewTwitchAPI.CHANNEL_EDIT_COMMERCIAL),
                (Endpoints.GET_EXTENSION_ANALYTICS , Scopes.NewTwitchAPI.ANALYTICS_READ_EXTENSIONS),
                (Endpoints.GET_CHEERMOTES , string.Empty), // OAuth or App Access Token required.
                (Endpoints.GET_BITS_LEADERBOARD , Scopes.NewTwitchAPI.BITS_READ),
                (Endpoints.GET_GAME_ANALYTICS , Scopes.NewTwitchAPI.ANALYTICS_READ_GAMES),
                (Endpoints.GET_EXTENSION_TRANSACTIONS , string.Empty), // App Access OAuth Token
                (Endpoints.CREATE_CLIP , Scopes.NewTwitchAPI.CLIPS_EDIT),
                (Endpoints.GET_CLIPS , string.Empty), // NONE
                (Endpoints.CREATE_ENTITLEMENT_GRANTS_UPLOAD_URL , string.Empty), // App access token
                // Authentication: Access is controlled via an app access token on the calling service. The client ID associated with the app access token must be approved by Twitch as part of a contracted arrangement.
                // Authorization: Callers with an app access token are authorized to redeem codes on behalf of any Twitch user account.
                (Endpoints.GET_CODE_STATUS , Scopes.NewTwitchAPI.CHANNEL_EDIT_COMMERCIAL),

                // Authentication: Access is controlled via an app access token on the calling service. The client ID associated with the app access token must be one approved by Twitch.
                // Authorization: Callers with an app access token as described above are authorized to redeem codes on behalf of any Twitch user account.
                (Endpoints.REDEEM_CODE , Scopes.NewTwitchAPI.CHANNEL_EDIT_COMMERCIAL),
                (Endpoints.GET_TOP_GAMES , string.Empty), // NONE
                (Endpoints.GET_GAMES , string.Empty), // NONE
                (Endpoints.CHECK_AUTO_MOD_STATUS , Scopes.NewTwitchAPI.MODERATION_READ),
                (Endpoints.GET_BANNED_USERS , Scopes.NewTwitchAPI.MODERATION_READ),
                (Endpoints.GET_BANNED_EVENTS , Scopes.NewTwitchAPI.MODERATION_READ),
                (Endpoints.GET_MODERATORS , Scopes.NewTwitchAPI.MODERATION_READ),
                (Endpoints.GET_MODERATOR_EVENTS , Scopes.NewTwitchAPI.MODERATION_READ),
                (Endpoints.SEARCH_CATEGORIES , string.Empty), // OAuth or App Access Token required
                (Endpoints.SEARCH_CHANNELS , string.Empty), // OAuth or App Access Token required
 
                (Endpoints.GET_STREAM_KEY , Scopes.NewTwitchAPI.CHANNEL_READ_STREAM_KEY),
                (Endpoints.GET_STREAMS , string.Empty), // OAuth or App Access Token required
                (Endpoints.CREATE_STREAM_MARKER , Scopes.NewTwitchAPI.USER_EDIT_BROADCAST),
                (Endpoints.GET_STREAM_MARKERS , Scopes.NewTwitchAPI.USER_READ_BROADCAST),
                (Endpoints.GET_CHANNEL_INFORMATION , string.Empty), // Valid user token or app access token
                (Endpoints.MODIFY_CHANNEL_INFORMATION , Scopes.NewTwitchAPI.USER_EDIT_BROADCAST), // PATCH
                (Endpoints.GET_BROADCASTER_SUBSCRIPTIONS , Scopes.NewTwitchAPI.CHANNEL_READ_SUBSCRIPTIONS),
                (Endpoints.GET_ALL_STREAM_TAGS , string.Empty), // App access token
                (Endpoints.GET_STREAM_TAGS , string.Empty), // App access token
                (Endpoints.REPLACE_STREAM_TAGS , Scopes.NewTwitchAPI.USER_EDIT_BROADCAST),

                (Endpoints.CREATE_USER_FOLLOWS , Scopes.NewTwitchAPI.USER_EDIT_FOLLOWS),
                (Endpoints.DELETE_USER_FOLLOWS , Scopes.NewTwitchAPI.USER_EDIT_FOLLOWS),
                (Endpoints.GET_USERS , Scopes.NewTwitchAPI.USER_READ_EMAIL),
                (Endpoints.GET_USERS_FOLLOWS , string.Empty), // NONE
                (Endpoints.UPDATE_USER , Scopes.NewTwitchAPI.USER_EDIT),
                (Endpoints.GET_USER_EXTENSIONS , Scopes.NewTwitchAPI.USER_READ_BROADCAST),
                (Endpoints.GET_USER_ACTIVE_EXTENSIONS , Scopes.NewTwitchAPI.USER_READ_BROADCAST), // or UserEditBroadcast
                (Endpoints.UPDATE_USER_EXTENSIONS , Scopes.NewTwitchAPI.USER_EDIT_BROADCAST),
                (Endpoints.GET_VIDEOS , string.Empty), // NONE
                (Endpoints.GET_WEBHOOK_SUBSCRIPTIONS , string.Empty), // App access token
 
                (Endpoints.GET_HYPE_TRAIN_EVENTS , Scopes.NewTwitchAPI.CHANNEL_READ_HYPE_TRAIN)
            };

            public static KeyValuePair<string, string>[] ScopeMap()
            {
                return s_ScopeMap.Select(x => new KeyValuePair<string, string>(x.Item1, x.Item2)).ToArray();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="endpoint"></param>
            /// <param name="scope"></param>
            public void AddScope(string endpoint, string scope)
            {
                List<(string, string)> items = new List<(string, string)>();
                items.Add((endpoint, scope));
                s_ScopeMap = items.ToArray();
            }
        }

        public class PubSub
        {
            [Serializable]
            public class Topics
            {
                public const string CHANNEL_BITS_EVENTS_V1 = "channel-bits-events-v1";
                public const string CHANNEL_BITS_EVENTS_V2 = "channel-bits-events-v2";
                public const string CHANNEL_BITS_BADGE_UNLOCKS = "channel-bits-badge-unlocks";
                public const string CHANNEL_POINTS_CHANNEL_V1 = "channel-points-channel-v1";
                public const string CHANNEL_SUBSCRIBE_EVENTS_V1 = "channel-subscribe-events-v1";
                public const string CHAT_MODERATOR_ACTIONS = "chat_moderator_actions";
                public const string WHISPER = "whispers";
            }

            static Dictionary<string, string> s_ScopeMap = new Dictionary<string, string>()
            {
                {Topics.CHANNEL_BITS_EVENTS_V1, Scopes.NewTwitchAPI.BITS_READ },
                {Topics.CHANNEL_BITS_EVENTS_V2, Scopes.NewTwitchAPI.BITS_READ },
                {Topics.CHANNEL_BITS_BADGE_UNLOCKS, Scopes.NewTwitchAPI.BITS_READ },
                {Topics.CHANNEL_POINTS_CHANNEL_V1, Scopes.ChatAndPubSub.CHANNEL_READ_REDEMPTIONS},
                {Topics.CHANNEL_SUBSCRIBE_EVENTS_V1, Scopes.TwitchAPIv5.CHANNEL_SUBSCRIPTIONS},
                {Topics.CHAT_MODERATOR_ACTIONS, Scopes.ChatAndPubSub.CHANNEL_MODERATE },
                {Topics.WHISPER, Scopes.ChatAndPubSub.WHISPERS_READ },
            };

            public static Dictionary<string, string> ScopeMap()
            {
                return s_ScopeMap;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="topic"></param>
            /// <param name="scope"></param>
            public void AddScope(string topic, string scope)
            {
                s_ScopeMap.Add(topic, scope);
            }
        }
    }
}