using System;
using System.Threading;


namespace Full_GRASP_And_SOLID
{
    public class RecipeClient : TimerClient
    {
        public Recipe Recipe;

        public RecipeClient(Recipe recipe)
        {
            this.Recipe = recipe;
        }

        public void RegisterTimer()
        {
            CountdownTimer timer = new CountdownTimer();
            timer.Register(this.Recipe.GetCookTime(), this);
        }
        public void TimeOut()
        {
            this.Recipe.SetCooked();
        }
    }
}