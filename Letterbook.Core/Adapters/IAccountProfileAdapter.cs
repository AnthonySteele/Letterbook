﻿using Letterbook.Core.Models;

namespace Letterbook.Core.Adapters;

public interface IAccountProfileAdapter : IDisposable
{
    delegate IQueryable<Profile> ProfileQuery(IQueryable<Profile> querySource);

    delegate IQueryable<Account> AccountQuery(IQueryable<Account> querySource);

    delegate bool ProfileComparer(Profile profile);

    public bool RecordAccount(Account account);
    public Task<bool> RecordAccounts(IEnumerable<Account> accounts);
    public Task<Account?> LookupAccount(Guid id);
    public IQueryable<Account> SearchAccounts();

    public Task<bool> AnyProfile(string handle);
    public Task<Profile?> LookupProfile(Guid localId);
    public Task<Profile?> LookupProfile(Uri id);
    
    // Lookup Profile including relations to another profile
    public Task<Profile?> LookupProfileWithRelation(Uri id, Uri relationId);
    public Task<Profile?> LookupProfileWithRelation(Guid localId, Uri relationId);
    
    public IAsyncEnumerable<Profile> QueryProfiles(ProfileQuery query, int? limit = null);

    public bool RecordProfile(Profile profile);

    public void Delete(object record);
    public Task Cancel();
    public Task Commit();
}