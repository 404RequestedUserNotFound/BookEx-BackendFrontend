var app = angular.module('my-app', []);
app.controller('authorAddCtrl', function($scope, $http) 
{
  $scope.createAuthor = function() 
  {
    var data = {
        AuthorName: $scope.AuthorName,
        AuthorId: $scope.AuthorId,
        AuthorBio: $scope.AuthorBio,
        PresentAddress: $scope.PresentAddress,
        AuthorEmail: $scope.AuthorEmail,
        Password: $scope.Password,
        ConfirmPassword: $scope.ConfirmPassword
      };
    $http.post("https://localhost:44373/api/author/add", data).then(function(resp) 
    {
      location.reload();

      alert("Author profile has created");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
