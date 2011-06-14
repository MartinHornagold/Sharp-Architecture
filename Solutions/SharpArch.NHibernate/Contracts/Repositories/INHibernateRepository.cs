namespace SharpArch.NHibernate.Contracts.Repositories
{
    using System;

    using SharpArch.Domain.PersistenceSupport;

    /// <summary>
    ///     Extends the basic data repository interface with an interface that supports a number 
    ///     of NHibernate specific methods while avoiding a concrete dependency on the NHibernate
    ///     assembly.  For looser coupling, the "Core" layers of the SharpArch library and of your 
    ///     application should not have a reference to the NHibernate assembly.
    /// </summary>
    public interface INHibernateRepository<T> : INHibernateRepositoryWithTypedId<T, Guid>, IRepository<T>
    {
    }
}