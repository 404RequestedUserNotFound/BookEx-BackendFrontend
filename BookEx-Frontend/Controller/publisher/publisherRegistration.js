var app = angular.module('my-app', []);
app.controller('publisherAddCtrl', function($scope, $http) 
{
  $scope.createPublisher = function() 
  {
    var data = {
        FirstName: $scope.firstName,
        LastName: $scope.lastName,
        Username: $scope.username,
        Phone: $scope.phone,
        Email: $scope.email,
        Password: $scope.password,
        Website: $scope.website
      };
    $http.post("https://localhost:44373/api/publisher/add", data).then(function(resp) 
    {
      location.reload();

      alert("Publisher profile has created");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
