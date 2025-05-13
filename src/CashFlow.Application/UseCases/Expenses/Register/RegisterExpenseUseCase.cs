using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpenseUseCase
{
    public ResponseRegisterdExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        return new ResponseRegisterdExpenseJson();
    }
}
