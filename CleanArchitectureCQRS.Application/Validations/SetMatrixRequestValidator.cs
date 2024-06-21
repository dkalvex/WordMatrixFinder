using CQRSProject.Shared.Requests;
using FluentValidation;

namespace CQRSProject.Application.Validations;

/// <summary>
///     Validator for <see cref="SetMatrixRequest"/> objects.
/// </summary>
public class SetMatrixRequestValidator : AbstractValidator<SetMatrixRequest>
{
    /// <summary>
    ///     Rule definitions for <see cref="SetMatrixRequestValidator"/> class.
    /// </summary>
    public SetMatrixRequestValidator()
    {
        RuleFor(x => x.Matrix)
            .NotEmpty().WithMessage("'{PropertyPath}' is required.")
            .Must(strings => strings!.Count() > 1).WithMessage("'{PropertyPath}' rows must be grather than 1")
            .Must(IsPerfectSquare).WithMessage("'{PropertyPath}' The number of elements in the list must allow to form a square matrix.");
    }

    /// <summary>
    ///     Determines whether the provided collection of strings can form a perfect square matrix.
    /// </summary>
    /// <param name="strings">The collection of strings to validate.</param>
    /// <returns>true if the number of elements allows forming a square matrix; otherwise, false.</returns>
    private bool IsPerfectSquare(IEnumerable<string>? strings)
    {
        var rows = strings!.Count();
        var columns = strings!.ToList().FirstOrDefault()!.Length;
        return rows == columns;
    }
}
