namespace Jellyfin.Plugin.SSO_Auth.Api;

/// <summary>
/// The body of a request to set an app password on an SSO-created account.
/// </summary>
public class AppPasswordRequest
{
    /// <summary>
    /// Gets or sets the new password.
    /// </summary>
    public string NewPassword { get; set; }
}
