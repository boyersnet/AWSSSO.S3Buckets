# AWSSSO.S3Buckets

Demo project for using AWSSSO with .NET SDK.

## Configuration

1. Assumes an existing AWS Account
2. Assumes there is at least 1 bucket within the AWS account.
3. Configue AWS SSO

```powershell
aws configure sso
```

4. (Optional) Configuring SSO sometimes gives an unfriendly profile name based on the permission set name. If you'd like to change the profile name to something more friendly, login to AWS using the AWS CLI v2.

```powershell
aws sso login --profile MyProfile
```

5. Configure the appsettings.json file with the profile

```json
{
  "AWS": {
    "Profile": "MyProfile",
    "Region": "us-east-1"
  }
}
```

6. Run the project which should write the bucket names out to the console window.
