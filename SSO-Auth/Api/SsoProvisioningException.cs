using System;

namespace Jellyfin.Plugin.SSO_Auth.Api;

/// <summary>
/// Raised when an SSO sign-in cannot be given an account, with a message safe to show the member.
/// </summary>
public class SsoProvisioningException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SsoProvisioningException"/> class.
    /// </summary>
    public SsoProvisioningException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SsoProvisioningException"/> class.
    /// </summary>
    /// <param name="message">The message shown to the member.</param>
    public SsoProvisioningException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SsoProvisioningException"/> class.
    /// </summary>
    /// <param name="message">The message shown to the member.</param>
    /// <param name="innerException">The underlying error.</param>
    public SsoProvisioningException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
