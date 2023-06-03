namespace DIInerhitance;

public interface IDependencyAggregate 
{
    IApplicationDbContext DbContext { get; }
    ICurrentUser { get; }
}

public class DependencyAggregate : IDependencyAggregate
{
    public DependencyAggregate(IApplicationDbContext dbContext, ICurrentUser currentUser)
    {
        DbContext = dbContext;
        CurrentUser = currentUser;
    }

    public IApplicationDbContext DbContext { get; }
    public ICurrentUser CurrentUser { get; }
}

public abstract class RequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    public RequestHandler(IDependencyAggregate aggregate)
    {
        DbContext = aggregate.DbContext;
        CurrentUser = aggregate.CurrentUser;
    }

    protected IApplicationDbContext DbContext { get; }
    protected ICurrentUser CurrentUser { get; }

    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}

public MyRequestHandler : RequestHandler<MyRequest, MyResponse>
{
public MyRequestHandler(IDependencyAggregate aggregate) : base(aggregate) { }

public override Task<MyResponse> Handle(MyRequest request, CancellationToken cancellationToken)
{
    // handler logic
}
}
