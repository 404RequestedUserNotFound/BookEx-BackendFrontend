var app = angular.module('my-app', []);
app.controller('authorUpdateCtrl', function($scope, $http) 
{
  $scope.updateAuthor = function() 
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
    $http.post("https://localhost:44373/api/author/update", data).then(function(resp) 
    {
      location.reload();

      alert("Author profile has updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
