using UnityEngine;


namespace BehaviorDesigner.Runtime.Tasks
{
    [TaskDescription("Log is a simple task which will output the specified text and return success. It can be used for debugging.")]
    [TaskIcon("{SkinColor}LogIcon.png")]
    public class TestLog : Action
    {
        [Tooltip("Text to output to the log")]
        public SharedString text;
        public override TaskStatus OnUpdate()
        {
            UnityEngine.Debug.LogError(text);
            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            text = "";
        }


    }
}