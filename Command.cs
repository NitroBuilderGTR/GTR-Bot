using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace GTR_Bot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        // Below is a normal Response.
        [Command("This is what the user will type")]
        public async Task Pizza404()
        {
            await ReplyAsync("This is the normal text reply.");
        }
        
        //Below is am embeded reply.
        [Command("This is what the user will type #2")]
        public async Task SendRichEmbedAsync()
        {
            var embed = new EmbedBuilder
            {
                // Embed property can be set within object initializer
                Title = "Hello world!",
                    Description = "I am a description set by initializer."
            };
            // Or with methods
            embed.AddField("Field title",
                "Field value. I also support [hyperlink markdown](https://example.com)!")
                .WithAuthor("GTR Bot")
                .WithFooter(footer => footer.Text = "Bot123")
                .WithTitle("Well \"Hello world!\"")
                .WithDescription("I am a description.")
                .WithUrl("https://example.com")
                .WithCurrentTimestamp();
