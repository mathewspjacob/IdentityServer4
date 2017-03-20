﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

#pragma warning disable CS1998

namespace IdentityServer4.Events
{
    internal static class IEventServiceExtensions
    {
        public static async Task RaiseLoginEventAsync(this IEventService events, ClaimsPrincipal user)
        {
            //var evt = new Event<LoginDetails>(
            //    EventConstants.Categories.Authentication,
            //    "Login",
            //    EventTypes.Information,
            //    EventConstants.Ids.UserLogin,
            //    new LoginDetails
            //    {
            //        SubjectId = user.GetSubjectId(),
            //        Name = user.GetName(),
            //        IdP = user.GetIdentityProvider(),
            //        Amr = user.GetAuthenticationMethod()
            //    });

            //await events.RaiseEventAsync(evt);
        }

        public static async Task RaiseLogoutEventAsync(this IEventService events, ClaimsPrincipal subject)
        {
        //    var evt = new Event<LogoutDetails>(
        //        EventConstants.Categories.Authentication,
        //        "Logout",
        //        EventTypes.Information,
        //        EventConstants.Ids.UserLogout,
        //        new LogoutDetails
        //        {
        //            SubjectId = subject.GetSubjectId(),
        //            Name = subject.GetName(),
        //        });

        //    await events.RaiseEventAsync(evt);
        }

       

        public static async Task RaiseTokenIssuedEventAsync(this IEventService events, Token token, string rawToken)
        {
            //if (token.Type == OidcConstants.TokenTypes.AccessToken)
            //{
            //    await events.RaiseAccessTokenIssuedEventAsync(token, rawToken);
            //}
            //else if (token.Type == OidcConstants.TokenTypes.IdentityToken)
            //{
            //    await events.RaiseIdentityTokenIssuedEventAsync(token);
            //}
        }

        public static async Task RaiseAccessTokenIssuedEventAsync(this IEventService events, Token token, string rawToken)
        {
            //var evt = new Event<AccessTokenIssuedDetails>(
            //    EventConstants.Categories.TokenService,
            //    "Access token issued",
            //    EventTypes.Information,
            //    EventConstants.Ids.AccessTokenIssued);

            //string referenceTokenHandle = null;
            //if (token.AccessTokenType == AccessTokenType.Reference)
            //{
            //    referenceTokenHandle = ObfuscateToken(rawToken);
            //}

            //evt.DetailsFunc = () => new AccessTokenIssuedDetails
            //{
            //    SubjectId = token.SubjectId ?? "no subject id",
            //    ClientId = token.ClientId,
            //    TokenType = token.AccessTokenType,
            //    Lifetime = token.Lifetime,
            //    Scopes = token.Scopes,
            //    Claims = token.Claims.ToClaimsDictionary(),
            //    ReferenceTokenHandle = referenceTokenHandle
            //};

            //await events.RaiseAsync(evt);
        }

        public static async Task RaiseIdentityTokenIssuedEventAsync(this IEventService events, Token token)
        {
            //var evt = new Event<TokenIssuedDetailsBase>(
            //    EventConstants.Categories.TokenService,
            //    "Identity token issued",
            //    EventTypes.Information,
            //    EventConstants.Ids.IdentityTokenIssued);

            //evt.DetailsFunc = () => new TokenIssuedDetailsBase
            //{
            //    SubjectId = token.SubjectId,
            //    ClientId = token.ClientId,
            //    Lifetime = token.Lifetime,
            //    Claims = token.Claims.ToClaimsDictionary()
            //};

            //await events.RaiseEventAsync(evt);
        }

        public static async Task RaiseAuthorizationCodeIssuedEventAsync(this IEventService events, string id, AuthorizationCode code)
        {
            //var evt = new Event<AuthorizationCodeDetails>(
            //    EventConstants.Categories.TokenService,
            //    "Authorization code issued",
            //    EventTypes.Information,
            //    EventConstants.Ids.AuthorizationCodeIssued);

            //evt.DetailsFunc = () => new AuthorizationCodeDetails
            //{
            //    HandleId = id,
            //    ClientId = code.ClientId,
            //    Scopes = code.RequestedScopes,
            //    SubjectId = code.Subject.GetSubjectId(),
            //    RedirectUri = code.RedirectUri,
            //    Lifetime = code.Lifetime
            //};

            //await events.RaiseEventAsync(evt);
        }

        public static async Task RaiseRefreshTokenIssuedEventAsync(this IEventService events, string id, RefreshToken token)
        {
            //var evt = new Event<RefreshTokenDetails>(
            //    EventConstants.Categories.TokenService,
            //    "Refresh token issued",
            //    EventTypes.Information,
            //    EventConstants.Ids.RefreshTokenIssued);

            //evt.DetailsFunc = () => new RefreshTokenDetails
            //{
            //    HandleId = id,
            //    ClientId = token.ClientId,
            //    Scopes = token.Scopes,
            //    SubjectId = token.SubjectId,
            //    Lifetime = token.Lifetime,
            //    Version = token.Version
            //};

            //await events.RaiseEventAsync(evt);
        }

        public static async Task RaiseSuccessfulRefreshTokenRefreshEventAsync(this IEventService events, string oldHandle, string newHandle, RefreshToken token)
        {
            //var evt = new Event<RefreshTokenRefreshDetails>(
            //    EventConstants.Categories.TokenService,
            //    "Refresh token refresh success",
            //    EventTypes.Success,
            //    EventConstants.Ids.RefreshTokenRefreshedSuccess);

            //evt.Details = new RefreshTokenRefreshDetails
            //{
            //    OldHandle = ObfuscateToken(oldHandle),
            //    NewHandle = ObfuscateToken(newHandle),
            //    ClientId = token.ClientId,
            //    Lifetime = token.Lifetime
            //};

            //await events.RaiseEventAsync(evt);
        }

        public static async Task RaiseSuccessfulIntrospectionEndpointEventAsync(this IEventService events, string token, string tokenStatus, string apiName)
        {
            //var evt = new Event<IntrospectionEndpointDetail>(
            //    EventConstants.Categories.Endpoints,
            //    "Introspection endpoint success",
            //    EventTypes.Success,
            //    EventConstants.Ids.IntrospectionEndpointSuccess,
            //    new IntrospectionEndpointDetail
            //    {
            //        Token = ObfuscateToken(token),
            //        TokenStatus = tokenStatus,
            //        ApiName = apiName
            //    });

            //await events.RaiseAsync(evt);
        }

        public static async Task RaiseFailureIntrospectionEndpointEventAsync(this IEventService events, string error, string token, string apiName)
        {
            //var evt = new Event<IntrospectionEndpointDetail>(
            //     EventConstants.Categories.Endpoints,
            //     "Introspection endpoint failure",
            //     EventTypes.Failure,
            //     EventConstants.Ids.IntrospectionEndpointFailure,
            //     new IntrospectionEndpointDetail
            //     {
            //         Token = ObfuscateToken(token),
            //         ApiName = apiName
            //     },
            //     error);

            //await events.RaiseAsync(evt);
        }

        public static async Task RaiseFailedAuthorizationCodeRedeemedEventAsync(this IEventService events, Client client, string handle, string error)
        {
            //var evt = new Event<AuthorizationCodeDetails>(
            //    EventConstants.Categories.TokenService,
            //    "Authorization code redeem failure",
            //    EventTypes.Failure,
            //    EventConstants.Ids.AuthorizationCodeRedeemedFailure,
            //    new AuthorizationCodeDetails
            //    {
            //        HandleId = handle,
            //        ClientId = client.ClientId
            //    },
            //    error);

            //await events.RaiseAsync(evt);
        }

        public static async Task RaiseSuccessAuthorizationCodeRedeemedEventAsync(this IEventService events, Client client, string handle)
        {
            //var evt = new Event<AuthorizationCodeDetails>(
            //    EventConstants.Categories.TokenService,
            //    "Authorization code redeem success",
            //    EventTypes.Success,
            //    EventConstants.Ids.AuthorizationCodeRedeemedSuccess,
            //    new AuthorizationCodeDetails
            //    {
            //        HandleId = handle,
            //        ClientId = client.ClientId
            //    });

            //await events.RaiseAsync(evt);
        }

        public static async Task RaiseFailedRefreshTokenRefreshEventAsync(this IEventService events, Client client, string handle, string error)
        {
            //var evt = new Event<RefreshTokenDetails>(
            //    EventConstants.Categories.TokenService,
            //    "Refresh token refresh failure",
            //    EventTypes.Failure,
            //    EventConstants.Ids.RefreshTokenRefreshedFailure,
            //    new RefreshTokenDetails
            //    {
            //        HandleId = ObfuscateToken(handle),
            //        ClientId = client.ClientId
            //    },
            //    error);

            //await events.RaiseAsync(evt);
        }

       

        private static string ObfuscateToken(string token)
        {
            string last4chars = "****";
            if (token.IsPresent() && token.Length > 4)
            {
                last4chars = token.Substring(token.Length - 4);
            }

            return "****" + last4chars;
        }
    }
}