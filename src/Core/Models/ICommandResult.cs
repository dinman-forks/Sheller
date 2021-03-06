using System;

namespace Sheller.Models
{
    /// <summary>
    /// The default result interface for executables.
    /// </summary>
    public interface ICommandResult
    {
        /// <summary>
        /// Succeeded property.
        /// </summary>
        /// <value>The succeeded status of an executable.</value>
        bool Succeeded { get; }

        /// <summary>
        /// ExitCode property.
        /// </summary>
        /// <value>The exit code of an executable.</value>
        int ExitCode { get; }

        /// <summary>
        /// StandardOutput property.
        /// </summary>
        /// <value>The standard output of an executable.</value>
        string StandardOutput { get; }

        /// <summary>
        /// StandardError property.
        /// </summary>
        /// <value>The standard error of an executable.</value>
        string StandardError { get; }

        /// <summary>
        /// StartTime property.
        /// </summary>
        /// <value>The start time of an executable.</value>
        DateTime StartTime { get; }

        /// <summary>
        /// EndTime property.
        /// </summary>
        /// <value>The end time of an executable.</value>
        DateTime EndTime { get; }

        /// <summary>
        /// RunTime property.
        /// </summary>
        /// <value>The run time of an executable.</value>
        TimeSpan RunTime { get; }
    }

    /// <summary>
    /// The default result interface for executables.
    /// </summary>
    /// <typeparam name="TResult">The result type of this <see cref="ICommandResult"/>.</typeparam>
    public interface ICommandResult<TResult> : ICommandResult
    {
        /// <summary>
        /// Result property.
        /// </summary>
        /// <value>The result of an executable.</value>
        TResult Result { get; }
    }
}