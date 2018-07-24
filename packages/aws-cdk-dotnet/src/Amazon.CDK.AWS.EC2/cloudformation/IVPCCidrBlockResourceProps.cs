using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EC2.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html </remarks>
    [JsiiInterface(typeof(IVPCCidrBlockResourceProps), "@aws-cdk/aws-ec2.cloudformation.VPCCidrBlockResourceProps")]
    public interface IVPCCidrBlockResourceProps
    {
        /// <summary>``AWS::EC2::VPCCidrBlock.VpcId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-vpcid </remarks>
        [JsiiProperty("vpcId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object VpcId
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::VPCCidrBlock.AmazonProvidedIpv6CidrBlock``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-amazonprovidedipv6cidrblock </remarks>
        [JsiiProperty("amazonProvidedIpv6CidrBlock", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object AmazonProvidedIpv6CidrBlock
        {
            get;
            set;
        }

        /// <summary>``AWS::EC2::VPCCidrBlock.CidrBlock``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-cidrblock </remarks>
        [JsiiProperty("cidrBlock", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object CidrBlock
        {
            get;
            set;
        }
    }
}