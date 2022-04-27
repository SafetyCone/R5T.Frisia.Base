using System;

using R5T.T0064;


namespace R5T.Frisia
{
    [ServiceDefinitionMarker]
    public interface IAwsEc2ServerSecretsProvider : IServiceDefinition
    {
        AwsEc2ServerSecrets GetAwsEc2ServerSecrets();
    }
}
