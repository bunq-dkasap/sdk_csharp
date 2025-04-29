using System.Collections.Generic;
using System.IO;
using System.Linq;
using Bunq.Sdk.Http;
using Bunq.Sdk.Model.Generated.Endpoint;
using Xunit;

namespace Bunq.Sdk.Tests.Model.Generated.Endpoint
{
    /// <summary>
    /// Tests:
    ///     Avatar
    ///     AttachmentPublic
    ///     AttachmentPublicContent
    /// </summary>
    public class AvatarTest : BunqSdkTestBase
    {
        /// <summary>
        /// Tests the creation of an avatar by uploading a picture via AttachmentPublic and setting it as avatar
        /// via the uuid.
        /// </summary>
        [Fact]
        public void TestCreateAvatarAndRetrieval()
        {
            SetUpTestCase();

            var fileContentByte = File.ReadAllBytes(PathAttachment + AttachmentPathIn);
            var attachmentUuid = UploadAvatarAndGetUuid(fileContentByte);

            var avatarMap = new Dictionary<string, object>
            {
                {AvatarApiObject.FIELD_ATTACHMENT_PUBLIC_UUID, attachmentUuid}
            };
            var avatarUuid = AvatarApiObject.Create(attachmentUuid).Value;

            var attachmentUuidFromAvatar = AvatarApiObject.Get(avatarUuid).Value
                .Image.First().AttachmentPublicUuid;
            var receivedFileContentByte = AttachmentPublicContentApiObject.List(attachmentUuidFromAvatar).Value;

            Assert.Equal(attachmentUuid, attachmentUuidFromAvatar);
            Assert.Equal(fileContentByte, receivedFileContentByte);
        }

        private static string UploadAvatarAndGetUuid(byte[] fileContentByte)
        {
            var customHeaders = new Dictionary<string, string>
            {
                {ApiClient.HEADER_ATTACHMENT_DESCRIPTION, AttachmentDescription},
                {ApiClient.HEADER_CONTENT_TYPE, ContentType},
            };

            return AttachmentPublicApiObject.Create(fileContentByte, customHeaders).Value;
        }
    }
}