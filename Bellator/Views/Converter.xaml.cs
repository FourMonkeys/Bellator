using System;
using System.Collections.Generic;
using Bellator.Services;
using Xamarin.Forms;

namespace Bellator.Views
{
    public partial class Converter : ContentPage
    {
        private bool SlowProgression = false;
        private bool RoundUp = true;
        private int CurrentXP = 0;
        private String ErrorMessage { get; set; }

        public Converter()
        {
            InitializeComponent();
        }

        void Handle_Pressed(object sender, System.EventArgs e)
        {
            try
            {
                ClassService classService = new ClassService();
                //Based on Current XP, determine what level the character is
                int currentLevel = classService.GetLevelFromXP(this.CurrentXP);
                int nextLevel = currentLevel + 1;

                
                ConversionService service = new ConversionService(currentLevel, this.CurrentXP, this.RoundUp, this.SlowProgression);
                    int ACP = service.ConvertXPToACP();
                    DisplayAlert("ACP", ACP.ToString(), "OK");
              

            }
            catch (NullReferenceException nre)
            {
                DisplayAlert("Alert", "Enter your Current XP Please!", "Ok");
            }
            catch (Exception exc)
            {
                DisplayAlert("Alert", exc.Message, "Ok");
            }
        }

        void Handle_RoundUpOnChanged(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            this.RoundUp = e.Value;
        }

        void Handle_SlowProgressionOnChanged(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            this.SlowProgression = e.Value;
        }

        void Handle_XPCompleted(object sender, System.EventArgs e)
        {
            try
            {
                //Need to handle what can come from the numeric keyboard
                //and set to int.
                double temp = Convert.ToDouble(EntryCurrentXP.Text);
                CurrentXP = Convert.ToInt32(temp);

                ClassService classService = new ClassService();
                //Based on Current XP, determine what level the character is
                int currentLevel = classService.GetLevelFromXP(this.CurrentXP);
                int nextLevel = currentLevel + 1;


                ConversionService service =
                    new ConversionService(currentLevel, this.CurrentXP,
                                          this.RoundUp, this.SlowProgression);
                int ACP = service.ConvertXPToACP();


                this.textLevel.Text = currentLevel.ToString();
                if (ACP < 136)
                {
                    this.textNextLevelACPEarned.Text = ACP.ToString();
                    this.textNextLevelACP.Label = "Progress Towards Level " +
                        (currentLevel + 1).ToString();

                    this.textNextLevelACP.Text =
                        ACP.ToString() + " of " +
                        service.NextLevelRequiredACP.ToString() +
                            " ACP's";
                }
                else
                {
                    this.textNextLevelACPEarned.Text = "MAX";
                    this.textNextLevelACP.Label = "Progress Towards Next Level ";
                    this.textNextLevelACP.Text = "MAX";
                }

                if (currentLevel == 1)
                {
                    this.textTotalACP.Text = ACP.ToString();
                }
                else
                {
                    this.textTotalACP.Text =
                        service.GetACPForCurrentLevel().ToString();
                }
                //If you've earned enough ACP to advance, tell the user. 
                //This could occur even if you haven't earned enough actual XP. 
                if(ACP == service.NextLevelRequiredACP)
                {
                    DisplayAlert("Level Up Alert!", 
                                 "Your XP was slightly under the required amount to level up, your ACP earned will let you level up to level " + nextLevel.ToString(), 
                                 "OK");
                }
            }
            catch(Exception exc)
            {
                var message = exc.Message;
            }

        }

    }
}
