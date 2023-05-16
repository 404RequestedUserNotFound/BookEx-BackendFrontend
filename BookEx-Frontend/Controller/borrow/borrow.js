var app = angular.module('my-app', []);
app.controller('borrowAddCtrl', function($scope, $http) 
{
  $scope.createBorrow = function() 
  {
    var data = {
        userId: $scope.userId,
        BookId: $scope.bookId,
        BorrowDate: $scope.borrowDate,
        DueDate: $scope.dueDate,
        ReturnDate: $scope.returnDate,
        Status: $scope.status,
        Fine: $scope.fine
      };
    $http.post("https://localhost:44373/api/borrow/add", data).then(function(resp) 
    {
      location.reload();

      alert("Borrow request has created");

    }, function(err) 

    {
      alert("Please fill all the fields");

    });
  };
});
