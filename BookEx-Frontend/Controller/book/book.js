var app = angular.module('my-app', []);
app.controller('bookAddCtrl', function($scope, $http) 
{
  $scope.createBook = function() 
  {
    var data = {
        Title: $scope.title,
        Author: $scope.author,
        Description: $scope.description,
        Price: $scope.price,
        Quantity: $scope.quantity,
        CategoryId: $scope.categoryid,
        PublisherId: $scope.publisherid,

      };
    $http.post("https://localhost:44373/api/book/add", data).then(function(resp) 
    {
      location.reload();

      alert("Book has added");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
