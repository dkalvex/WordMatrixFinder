using System.Reflection;

namespace CQRSProject.Application;

/// <summary>
///     Provides a reference to the assembly <see cref="ProjectAssemblyReference"/> class.
/// </summary>
public static class ProjectAssemblyReference
{
    /// <summary>
    ///     Gets the assembly that contains the <see cref="ProjectAssemblyReference"/> class.
    /// </summary>
    public static Assembly Assembly { get; } = typeof(ProjectAssemblyReference).Assembly;
}