using AdobeUserManagementApi.Models.Groups;
using System.Text.Json;


namespace AdobeUserManagementApiTests.JsonSerilize.Groups
{
    public class TestAddRemoveJSon
    {
        [Fact]
        public void TestAddremove()
        {
            const string expected = "[{\"usergroup\":\"TestGroup\",\"do\":[{\"add\":{\"user\":[\"test1@test.com\",\"test2@test.com\"]},\"remove\":{\"user\":[\"test3@test.com\",\"test4@test.com\"]}}]}]";

            List<string> addMembers = new()
            {
                "test1@test.com",
                "test2@test.com"
            };

            List<string> removeMember = new()
            {
                "test3@test.com",
                "test4@test.com"
            };

            UpdateGroupMembers<AddRemoveMembersModel> AddRemove = new()
            {
                Usergroup = "TestGroup",
                Do = new List<AddRemoveMembersModel>
                {
                    new AddRemoveMembersModel(addMembers, removeMember)
                }
            };

            var json = JsonSerializer.Serialize(new[] { AddRemove });

            Assert.Equal(expected, json);
        }
    }
}
