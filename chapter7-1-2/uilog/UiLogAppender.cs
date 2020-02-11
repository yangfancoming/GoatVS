using System;
using log4net.Appender;
using log4net.Core;

namespace chapter7_1_2.uilog {

//    public abstract class UiLogAppender : AppenderSkeleton {   doit 为什么这里加上 abstract  就无法再打印日志了？？？
    public class UiLogAppender : AppenderSkeleton {

        public event EventHandler<UiLogEventArgs> UiLogReceived;

        protected override void Append(LoggingEvent loggingEvent) {
            var message = RenderLoggingEvent(loggingEvent);
            OnUiLogReceived(new UiLogEventArgs(message));
        }

        protected virtual void OnUiLogReceived(UiLogEventArgs e) {
            UiLogReceived?.Invoke(this, e);
        }

    }
}