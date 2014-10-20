using System;

namespace CurveLock
{
  internal interface ICompletePanel
  {
    event EventHandler<EventArgs> Complete;
  }
}
