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
    /// <summary>
    /// Endpoints and scopes to make API requests
    /// </summary>
    public static class Authentication
    {
        /// <summary>
        /// Endpoint base url append trget endpoint to make request
        /// </summary>
        public const string BASE_URL = "https://api.twitch.tv/helix";

        /// <summary>
        /// Scope and topic or endpoint map item
        /// </summary>
        public class Scoped
        {
            /// <summary>
            /// Topic or endppoint used for scope refernece
            /// </summary>
            public string key { get; set; }

            /// <summary>
            /// The scope required to use the key (topic or endpoint)
            /// </summary>
            public string scope { get; set; }
        }

        /// <summary>
        /// Scope and endpoint map item
        /// </summary>
        public class ScopedEndpoint : Scoped
        {
            /// <summary>
            /// The http method use to make the request ie. "POST"
            /// </summary>
            public string method { get; set; }
        }

        static string GetEndpointUrl(string url)
        {
            string baseUrl = url.Split('?')[0];
            return baseUrl;
        }

        /// <summary>
        /// Does the scope exist in the internal list
        /// </summary>
        /// <param name="scope">Scope to look up</param>
        /// <returns></returns>
        public static bool HasScope(string scope)
        {
            foreach (var item in Helix.ScopeMap())
            {
                if (item.scope == scope) return true;
            }
            return false;
        }

        /// <summary>
        /// Get the scope associated with an endpoint
        /// </summary>
        /// <param name="method">The http method to make the request</param>
        /// <param name="url">Fully qualified endpoint url</param>
        /// <returns>The associated scope</returns>
        public static string GetAssociatedScope(string method, string url)
        {
            string endpoint = GetEndpointUrl(url);
            foreach (var item in Helix.ScopeMap())
            {
                if (item.method == method && item.key == endpoint) return item.scope;
            }

            return string.Empty;
        }

        /// <summary>
        /// Endpoints avaiable from the API
        /// </summary>
        public static class Endpoints
        {
            /// <summary>
            /// Starts a commercial on a specified channel.
            /// </summary>
            public const string START_COMMERCIAL = BASE_URL + "/channels/commercial";

            /// <summary>
            /// Gets a URL that extension developers can use to download analytics reports (CSV files) for their extensions.
            /// </summary>
            public const string GET_EXTENSION_ANALYTICS = BASE_URL + "/analytics/extensions";

            /// <summary>
            /// Retrieves the list of available Cheermotes, animated emotes to which viewers can assign Bits, to cheer in chat.
            /// </summary>
            public const string GET_CHEERMOTES = BASE_URL + "/bits/cheermotes";

            /// <summary>
            /// Gets a ranked list of Bits leaderboard information for an authorized broadcaster.
            /// </summary>
            public const string GET_BITS_LEADERBOARD = BASE_URL + "/bits/leaderboard";

            /// <summary>
            /// Gets a URL that game developers can use to download analytics reports (CSV files) for their games.
            /// </summary>
            public const string GET_GAME_ANALYTICS = BASE_URL + "/analytics/games";

            /// <summary>
            /// Get Extension Transactions allows extension back end servers to fetch a list of transactions that have occurred for their extension across all of Twitch.
            /// </summary>
            public const string GET_EXTENSION_TRANSACTIONS = BASE_URL + "/extensions/transactions"; // in docs helix/extensions/transactions

            /// <summary>
            /// Creates a clip programmatically. This returns both an ID and an edit URL for the new clip.
            /// </summary>
            public const string CREATE_CLIP = BASE_URL + "/clips";

            /// <summary>
            /// Gets clip information by clip ID (one or more), broadcaster ID (one only), or game ID (one only). 
            /// </summary>
            public const string GET_CLIPS = BASE_URL + "/clips";

            /// <summary>
            /// Creates a URL where you can upload a manifest file and notify users that they have an entitlement.
            /// </summary>
            public const string CREATE_ENTITLEMENT_GRANTS_UPLOAD_URL = BASE_URL + "/entitlements/upload";

            /// <summary>
            /// Gets the status of one or more provided Bits codes.
            /// </summary>
            public const string GET_CODE_STATUS = BASE_URL + "/entitlements/codes";

            /// <summary>
            /// Redeems one or more provided Bits codes to the authenticated Twitch user.
            /// </summary>
            public const string REDEEM_CODE = BASE_URL + "/entitlements/code";

            /// <summary>
            /// Gets games sorted by number of current viewers on Twitch, most popular first.
            /// </summary>
            public const string GET_TOP_GAMES = BASE_URL + "/games/top";

            /// <summary>
            /// Gets game information by game ID or name.
            /// </summary>
            public const string GET_GAMES = BASE_URL + "/games";

            /// <summary>
            /// Gets the information of the most recent Hype Train of the given channel ID.
            /// </summary>
            public const string CHECK_AUTO_MOD_STATUS = BASE_URL + "/moderation/enforcements/status";

            /// <summary>
            /// Returns all banned and timed-out users in a channel.
            /// </summary>
            public const string GET_BANNED_USERS = BASE_URL + "/moderation/banned";

            /// <summary>
            /// Returns all user bans and un-bans in a channel.
            /// </summary>
            public const string GET_BANNED_EVENTS = BASE_URL + "/moderation/banned/events";

            /// <summary>
            /// Returns all moderators in a channel.
            /// </summary>
            public const string GET_MODERATORS = BASE_URL + "/moderation/moderators";

            /// <summary>
            /// Returns a list of moderators or users added and removed as moderators from a channel.
            /// </summary>
            public const string GET_MODERATOR_EVENTS = BASE_URL + "/moderation/moderators/events";

            /// <summary>
            /// Returns a list of games or categories that match the query via name either entirely or partially.
            /// </summary>
            public const string SEARCH_CATEGORIES = BASE_URL + "/search/categories ";

            /// <summary>
            /// Returns a list of channels (users who have streamed within the past 6 months)
            /// <para>that match the query via channel name or description either entirely or partially.</para>
            /// </summary>
            public const string SEARCH_CHANNELS = BASE_URL + "/search/channels"; // in docs helix/search/channels

            /// <summary>
            /// Gets the channel stream key for a user.
            /// </summary>
            public const string GET_STREAM_KEY = BASE_URL + "/streams/key";

            /// <summary>
            /// Gets information about active streams. Streams are returned sorted by number of current viewers, in descending order.
            /// </summary>
            public const string GET_STREAMS = BASE_URL + "/streams";

            /// <summary>
            /// Creates a marker in the stream of a user specified by user ID.
            /// </summary>
            public const string CREATE_STREAM_MARKER = BASE_URL + "/streams/markers";

            /// <summary>
            /// Gets a list of markers for either a specified user’s most recent stream or a specified VOD/video (stream), ordered by recency.
            /// </summary>
            public const string GET_STREAM_MARKERS = BASE_URL + "/streams/markers";

            /// <summary>
            /// Gets channel information for users.
            /// </summary>
            public const string GET_CHANNEL_INFORMATION = BASE_URL + "/channels";

            /// <summary>
            /// Modifies channel information for users.
            /// </summary>
            public const string MODIFY_CHANNEL_INFORMATION = BASE_URL + "/channels"; // PATCH

            /// <summary>
            /// Get all of a broadcaster’s subscriptions.
            /// </summary>
            public const string GET_BROADCASTER_SUBSCRIPTIONS = BASE_URL + "/subscriptions";

            /// <summary>
            /// Gets the list of all stream tags defined by Twitch, optionally filtered by tag ID(s).
            /// </summary>
            public const string GET_ALL_STREAM_TAGS = BASE_URL + "/tags/streams";

            /// <summary>
            /// Gets the list of tags for a specified stream (channel).
            /// </summary>
            public const string GET_STREAM_TAGS = BASE_URL + "/streams/tags";

            /// <summary>
            /// Applies specified tags to a specified stream, overwriting any existing tags applied to that stream.
            /// </summary>
            public const string REPLACE_STREAM_TAGS = BASE_URL + "/streams/tags";

            /// <summary>
            /// Adds a specified user to the followers of a specified channel.
            /// </summary>
            public const string CREATE_USER_FOLLOWS = BASE_URL + "/users/follows";

            /// <summary>
            /// Deletes a specified user from the followers of a specified channel.
            /// </summary>
            public const string DELETE_USER_FOLLOWS = BASE_URL + "/users/follows";

            /// <summary>
            /// Gets information about one or more specified Twitch users.
            /// </summary>
            public const string GET_USERS = BASE_URL + "/users";

            /// <summary>
            /// Gets information on follow relationships between two Twitch users.
            /// </summary>
            public const string GET_USERS_FOLLOWS = BASE_URL + "/users/follows";

            /// <summary>
            /// Updates the description of a user specified by a Bearer token.
            /// </summary>
            public const string UPDATE_USER = BASE_URL + "/users";

            /// <summary>
            /// Gets a list of all extensions (both active and inactive) for a specified user, identified by a Bearer token.
            /// </summary>
            public const string GET_USER_EXTENSIONS = BASE_URL + "/users/extensions/list";

            /// <summary>
            /// Gets information about active extensions installed by a specified user, identified by a user ID or Bearer token.
            /// </summary>
            public const string GET_USER_ACTIVE_EXTENSIONS = BASE_URL + "/users/extensions";

            /// <summary>
            /// Updates the activation state, extension ID, and/or version number of installed extensions for a specified user, identified by a Bearer token.
            /// </summary>
            public const string UPDATE_USER_EXTENSIONS = BASE_URL + "/users/extensions";

            /// <summary>
            /// Gets video information by video ID (one or more), user ID (one only), or game ID (one only).
            /// </summary>
            public const string GET_VIDEOS = BASE_URL + "/videos";

            /// <summary>
            /// Gets the Webhook subscriptions of a user identified by a Bearer token, in order of expiration.
            /// </summary>
            public const string GET_WEBHOOK_SUBSCRIPTIONS = BASE_URL + "/webhooks/subscriptions";

            /// <summary>
            /// Gets the information of the most recent Hype Train of the given channel ID.
            /// </summary>
            public const string GET_HYPE_TRAIN_EVENTS = BASE_URL + "/hypetrain/events";

            /// <summary>
            /// Get the endpoint without the base url {Authentication.BASE_URL}
            /// </summary>
            /// <param name="url">Fully qualified url</param>
            /// <returns>Endpoint without the base url ie. /users/follows</returns>
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

        /// <summary>
        /// Helis API scopes and endpoints
        /// </summary>
        public class Helix
        {
            static (string, string, string)[] s_ScopeMap = new (string, string, string)[]
            {
                (Method.POST, Endpoints.START_COMMERCIAL, Scopes.NewTwitchAPI.CHANNEL_EDIT_COMMERCIAL),
                (Method.GET, Endpoints.GET_EXTENSION_ANALYTICS, Scopes.NewTwitchAPI.ANALYTICS_READ_EXTENSIONS),
                (Method.GET, Endpoints.GET_CHEERMOTES, string.Empty), // OAuth or App Access Token required.
                (Method.GET, Endpoints.GET_BITS_LEADERBOARD, Scopes.NewTwitchAPI.BITS_READ),
                (Method.GET, Endpoints.GET_GAME_ANALYTICS, Scopes.NewTwitchAPI.ANALYTICS_READ_GAMES),
                (Method.GET, Endpoints.GET_EXTENSION_TRANSACTIONS, string.Empty), // App Access OAuth Token
                (Method.POST, Endpoints.CREATE_CLIP, Scopes.NewTwitchAPI.CLIPS_EDIT),
                (Method.GET, Endpoints.GET_CLIPS, string.Empty), // NONE
                (Method.POST, Endpoints.CREATE_ENTITLEMENT_GRANTS_UPLOAD_URL, string.Empty), // App access token
                // Authentication: Access is controlled via an app access token on the calling service. The client ID associated with the app access token must be approved by Twitch as part of a contracted arrangement.
                // Authorization: Callers with an app access token are authorized to redeem codes on behalf of any Twitch user account.
                (Method.GET, Endpoints.GET_CODE_STATUS, Scopes.NewTwitchAPI.CHANNEL_EDIT_COMMERCIAL),
                 
                // Authentication: Access is controlled via an app access token on the calling service. The client ID associated with the app access token must be one approved by Twitch.
                // Authorization: Callers with an app access token as described above are authorized to redeem codes on behalf of any Twitch user account.
                (Method.POST, Endpoints.REDEEM_CODE, Scopes.NewTwitchAPI.CHANNEL_EDIT_COMMERCIAL),
                (Method.GET, Endpoints.GET_TOP_GAMES, string.Empty), // NONE
                (Method.GET, Endpoints.GET_GAMES, string.Empty), // NONE
                (Method.POST, Endpoints.CHECK_AUTO_MOD_STATUS, Scopes.NewTwitchAPI.MODERATION_READ),
                (Method.GET, Endpoints.GET_BANNED_USERS, Scopes.NewTwitchAPI.MODERATION_READ),
                (Method.GET, Endpoints.GET_BANNED_EVENTS, Scopes.NewTwitchAPI.MODERATION_READ),
                (Method.GET, Endpoints.GET_MODERATORS, Scopes.NewTwitchAPI.MODERATION_READ),
                (Method.GET, Endpoints.GET_MODERATOR_EVENTS, Scopes.NewTwitchAPI.MODERATION_READ),
                (Method.GET, Endpoints.SEARCH_CATEGORIES, string.Empty), // OAuth or App Access Token required
                (Method.GET, Endpoints.SEARCH_CHANNELS, string.Empty), // OAuth or App Access Token required
                 
                (Method.GET, Endpoints.GET_STREAM_KEY, Scopes.NewTwitchAPI.CHANNEL_READ_STREAM_KEY),
                (Method.GET, Endpoints.GET_STREAMS, string.Empty), // OAuth or App Access Token required
                (Method.POST, Endpoints.CREATE_STREAM_MARKER, Scopes.NewTwitchAPI.USER_EDIT_BROADCAST),
                (Method.GET, Endpoints.GET_STREAM_MARKERS, Scopes.NewTwitchAPI.USER_READ_BROADCAST),
                (Method.GET, Endpoints.GET_CHANNEL_INFORMATION, string.Empty), // Valid user token or app access token
                (Method.PATCH, Endpoints.MODIFY_CHANNEL_INFORMATION, Scopes.NewTwitchAPI.USER_EDIT_BROADCAST), // PATCH
                (Method.GET, Endpoints.GET_BROADCASTER_SUBSCRIPTIONS, Scopes.NewTwitchAPI.CHANNEL_READ_SUBSCRIPTIONS),
                (Method.GET, Endpoints.GET_ALL_STREAM_TAGS, string.Empty), // App access token
                (Method.GET, Endpoints.GET_STREAM_TAGS, string.Empty), // App access token
                (Method.PUT, Endpoints.REPLACE_STREAM_TAGS, Scopes.NewTwitchAPI.USER_EDIT_BROADCAST),
                 
                (Method.POST, Endpoints.CREATE_USER_FOLLOWS, Scopes.NewTwitchAPI.USER_EDIT_FOLLOWS),
                (Method.DELETE, Endpoints.DELETE_USER_FOLLOWS, Scopes.NewTwitchAPI.USER_EDIT_FOLLOWS),
                (Method.GET, Endpoints.GET_USERS, Scopes.NewTwitchAPI.USER_READ_EMAIL),
                (Method.GET, Endpoints.GET_USERS_FOLLOWS, string.Empty), // NONE
                (Method.PUT, Endpoints.UPDATE_USER, Scopes.NewTwitchAPI.USER_EDIT),
                (Method.GET, Endpoints.GET_USER_EXTENSIONS, Scopes.NewTwitchAPI.USER_READ_BROADCAST),
                (Method.GET, Endpoints.GET_USER_ACTIVE_EXTENSIONS, Scopes.NewTwitchAPI.USER_READ_BROADCAST), // or UserEditBroadcast
                (Method.PUT, Endpoints.UPDATE_USER_EXTENSIONS, Scopes.NewTwitchAPI.USER_EDIT_BROADCAST),
                (Method.GET, Endpoints.GET_VIDEOS, string.Empty), // NONE
                (Method.GET, Endpoints.GET_WEBHOOK_SUBSCRIPTIONS, string.Empty), // App access token
                 
                (Method.GET, Endpoints.GET_HYPE_TRAIN_EVENTS, Scopes.NewTwitchAPI.CHANNEL_READ_HYPE_TRAIN)
            };

            /// <summary>
            /// Mapping of the API endpoints to the required scopes
            /// </summary>
            /// <returns></returns>
            public static ScopedEndpoint[] ScopeMap()
            {
                return s_ScopeMap.Select(x => new ScopedEndpoint { method = x.Item1, key = x.Item2, scope = x.Item3 }).ToArray();
            }

            /// <summary>
            /// Add a scope to the endpoint map
            /// </summary>
            /// <param name="method">The http method used to make the request. ie "POST"</param>
            /// <param name="endpoint">The endpoint without the base url</param>
            /// <param name="scope">Scope that the endpoint requires</param>
            public void AddScope(string method, string endpoint, string scope)
            {
                List<(string, string, string)> items = new List<(string, string, string)>();
                items.Add((method, endpoint, scope));
                s_ScopeMap = items.ToArray();
            }
        }

        /// <summary>
        /// PubSub topics and scopes
        /// <para>PubSub enables you to subscribe to a topic, for updates (e.g., when a user cheers in a channel).</para>
        /// </summary>
        public class PubSub
        {
            /// <summary>
            /// Topics to subscribe to to receive events
            /// </summary>
            [Serializable]
            public class Topics
            {
                /// <summary>
                /// Anyone cheers in a specified channel.
                /// </summary>
                public const string CHANNEL_BITS_EVENTS_V1 = "channel-bits-events-v1";

                /// <summary>
                /// Anyone cheers in a specified channel.
                /// </summary>
                public const string CHANNEL_BITS_EVENTS_V2 = "channel-bits-events-v2";

                /// <summary>
                /// Message sent when a user earns a new Bits badge in a particular channel, and chooses to share the notification with chat.
                /// </summary>
                public const string CHANNEL_BITS_BADGE_UNLOCKS = "channel-bits-badge-unlocks";

                /// <summary>
                /// A custom reward is redeemed in a channel.
                /// </summary>
                public const string CHANNEL_POINTS_CHANNEL_V1 = "channel-points-channel-v1";

                /// <summary>
                /// Anyone subscribes (first month), resubscribes (subsequent months), or gifts a subscription to a channel.
                /// <para>Subgift subscription messages contain recipient information.</para>
                /// </summary>
                public const string CHANNEL_SUBSCRIBE_EVENTS_V1 = "channel-subscribe-events-v1";

                /// <summary>
                /// A moderator performs an action in the channel. 
                /// </summary>
                public const string CHAT_MODERATOR_ACTIONS = "chat_moderator_actions";

                /// <summary>
                /// Anyone whispers the specified user.
                /// </summary>
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


            /// <summary>
            /// Mapping of the API topics to the required scopes
            /// </summary>
            /// <returns></returns>
            public static Scoped[] ScopeMap()
            {
                return s_ScopeMap.Select(x => new Scoped { key = x.Key, scope = x.Value }).ToArray();
            }

            /// <summary>
            /// Add a scope to the endpoint map
            /// </summary>
            /// <param name="topic">The topic that requires the scope</param>
            /// <param name="scope">Scope that the topic requires</param>
            public void AddScope(string topic, string scope)
            {
                s_ScopeMap.Add(topic, scope);
            }
        }
    }
}