using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace botmot
{
    public class Botmot : IBot
    {
        public async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {
            // ユーザーのメッセージにだけ返信
            // Text プロパティの値をオウム返し
            if (turnContext.Activity.Type == ActivityTypes.Message
                && !string.IsNullOrEmpty(turnContext.Activity.Text))
                await turnContext.SendActivityAsync(turnContext.Activity.Text);
        }
    }
}
