using System;


namespace R5T.Frisia
{
    public interface IAwsEc2ServerSecretsProvider
    {
        AwsEc2ServerSecrets GetAwsEc2ServerSecrets();
    }
}
