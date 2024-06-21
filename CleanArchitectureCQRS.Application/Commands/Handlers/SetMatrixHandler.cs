using CQRSProject.Application.Services.WordMatrix;
using CQRSProject.Shared.Requests;
using CQRSProject.Shared.Responses;
using FluentValidation;
using MediatR;

namespace CQRSProject.Application.Commands.Handlers;

/// <summary>
///     Handles set matrix requests.
/// </summary>
public class SetMatrixHandler : IRequestHandler<SetMatrixRequest, GetMatrixResponse>
{
    private readonly IWordMatrix wordMatrix;
    private readonly IValidator<SetMatrixRequest> validator;
    public SetMatrixHandler(
        IWordMatrix wordMatrix, 
        IValidator<SetMatrixRequest> validator
    ) { 
        this.wordMatrix = wordMatrix;
        this.validator = validator;
    }
    /// <summary>
    ///     Handles set matrix requests.
    /// </summary>
    /// <param name="request">The set matrix request.</param>
    /// <param name="cancellationToken"> The cancellation token.</param>
    /// <returns>The new matrix as a list of string.</returns>
    /// <exception cref="ValidationException"> Represent the validation for the set matrix request.</exception>
    public async Task<GetMatrixResponse> Handle(SetMatrixRequest request, CancellationToken cancellationToken)
    {
        var validResult = validator.Validate(request);
        if (!validResult.IsValid)
        {
            throw new ValidationException(validResult.Errors);
        }
        wordMatrix.SetMatrix(request.Matrix!);
        return await Task.FromResult(new GetMatrixResponse() { Matrix = wordMatrix.GetMatrix() });
    }
}
