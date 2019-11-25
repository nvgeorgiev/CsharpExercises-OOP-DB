﻿namespace WorkflowEngine
{
    using System.Collections.Generic;

    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}
