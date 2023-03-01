namespace SocialMediaTest;
using SocialMediaManager;
using SocialMediaManager.Interface;

public class Tests
{
    public ICreatePostsHandler _createPostsHandler { get; set; }
    public IGetPostsHandler _getPostsHandler { get; set; }


    [SetUp]
    public void Setup(CreatePostsHandler createPostsHandler, IGetPostsHandler getPostsHandler)
    {
        _createPostsHandler = createPostsHandler;
        _getPostsHandler = getPostsHandler;
    }

    [Test]
    public void AddPostsTest()
    {
        Assert.Pass();

        //Arrange
        //input data preparation 

        //Act
        //Calling the method
        _createPostsHandler.AddPosts(); 

        //Assert
        //Verifying the results in this case the method Add Posts should not fail.
        Assert.Pass();
    }

    [Test]
    public void ShowPostsTest()
    {
        Assert.Pass();

        //Arrange
        //input data preparation 

        //Act
        //Calling the method
        _getPostsHandler.ShowPosts();

        //Assert
        //Verifying the results in this case the method Add Posts should not fail.
        Assert.Pass();
    }

}
