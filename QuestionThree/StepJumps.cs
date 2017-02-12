using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    public class StepJumps
    {
        /// <summary>
        /// This will allow input for Jack 
        /// and testing purposes. Otherwise, the 
        /// constructor would serve no purpose.
        /// </summary>
        /// <param name="N"></param>
        /// <param name="K"></param>
        public StepJumps()
        {
            InstantiateStepSetting();
        }

        public StepJumps(int N, int K)
        {
            StepsN = N;
            BrokenStepN = N;
        }

        public int StepsN { get; private set; }

        public int BrokenStepN { get; private set; }

        /// <summary>
        /// Optimizes for the max steps Jack can take 
        /// </summary>
        /// <param name="N">Jack's step goal</param>
        /// <param name="K">A single broken step in N</param>
        /// <returns></returns>
        public int maxstep(int N, int K)
        {
            StepsN = N;
            BrokenStepN = K;

            // Keep track of Jack's steps in the case he wants to jump less than N-1 times
            int jacksCurrentSteps = 0;
            int jacksAction = 0;
            
            // Only break out if Jack has reached his step goal
            while (jacksCurrentSteps < StepsN)
            {
                Console.WriteLine("Jack's current step: " + jacksCurrentSteps);
                Console.WriteLine("Enter your action Jack or type any keystroke other than a number to stay where you are");
                string nextAction = Console.ReadLine();
                bool isValidInteger = int.TryParse(nextAction, out jacksAction);
                
                // If Jack is fine with what step he is on
                if (!isValidInteger)
                {
                    break;
                }
                else
                {
                    // Keep track of our actions
                    jacksCurrentSteps += jacksAction;                    
                    if (jacksCurrentSteps == BrokenStepN)
                    {
                        // Assure Jack never steps on the broken one 
                        jacksCurrentSteps++;
                    }
                }
            }

            Console.WriteLine("Final result is: "  + jacksCurrentSteps);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            return jacksCurrentSteps;
        }

        private void InstantiateStepSetting()
        {
            int stepsN;
            int brokenStepK;

            while (true)
            {
                Console.WriteLine("Welcome Jack!");
                Console.WriteLine("Please enter how many steps you want to get to: ");
                string inputStepsN = Console.ReadLine();
                bool isStepsNValid = int.TryParse(inputStepsN, out stepsN);

                Console.WriteLine("Please enter where the broken step will be: ");
                string inputBrokenStepN = Console.ReadLine();
                bool isBrokenStepKValid = int.TryParse(inputBrokenStepN, out brokenStepK);

                if (!isStepsNValid || !isBrokenStepKValid)
                {
                    Console.WriteLine("Input must be of type integer only!");
                    continue;
                }
                else
                {
                    StepsN = stepsN;
                    BrokenStepN = brokenStepK;
                    break;
                }
            }

            maxstep(StepsN, BrokenStepN);
        }
    }
}
