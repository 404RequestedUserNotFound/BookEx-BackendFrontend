var app = angular.module('my-app', []);
app.controller('bookUpdateCtrl', function($scope, $http) 
{
  $scope.updateBook = function() 
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
    $http.post("https://localhost:44373/api/book/update", data).then(function(resp) 
    {
      location.reload();

      alert("book name has updated");


    }, function(err) 

    {
      alert("Please fill all the fields");


    });
  };
});
