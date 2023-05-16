var app = angular.module('my-app', []);
app.controller('publisherUpdateCtrl', function($scope, $http) 
{
  $scope.updatePublisher = function() 
  {
    var data = {
        Id: $scope.publisherId,
        FirstName: $scope.firstName,
        LastName: $scope.lastName,
        Username: $scope.username,
        Email: $scope.email,
        Password: $scope.password,
        Website: $scope.website
      };
    $http.post("https://localhost:44373/api/publisher/update", data).then(function(resp) 
    {
      location.reload();

      alert("Publisher profile has been updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
