using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;

namespace BotFormFlow.Forms
{
    [Serializable]
    public class ScheduleForm
    {
        [Prompt("When is the Activity")]
        public string date;
        [Prompt("Where is the activity?")]
        public string locality;
        [Prompt("Brief description of the activity")]
        public string description;

        public static IForm<ScheduleForm> BuildForm()
        {
            return new FormBuilder<ScheduleForm>()
                .Message("Welcome")
                .OnCompletion(async (context, scheduleform) =>
                {
                    await context.PostAsync("Your new schedule is complete.");
                })
                .Build();

        }

    }
}