﻿using Telegram.Bot.Types;

namespace XinjingdailyBot.Infrastructure.Extensions
{
    public static class ChatExtension
    {
        public static string ChatID(this Chat chat)
        {
            return string.IsNullOrEmpty(chat.Username) ? $"#{chat.Id}" : $"@{chat.Username}";
        }

        public static string FullChatID(this Chat chat)
        {
            return string.IsNullOrEmpty(chat.Username) ? $"#{chat.Id}" : $"@{chat.Username} #{chat.Id}";
        }

        public static string ChatProfile(this Chat chat)
        {
            return $"{chat.Title} {chat.ChatID()}";
        }

        public static string FullChatProfile(this Chat chat)
        {
            return $"{chat.Title} {chat.FullChatID()}";
        }

        /// <summary>
        /// HTML转义后的聊天名
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string EscapedChatName(this Chat chat)
        {
            return chat.Title?.EscapeHtml() ?? "";
        }
    }
}
