(function () {
    "use strict";

    angular
        .module("common.services",
            ["ngResource"])
        .constant("appSettings",
        {
            //serverPath: "http://localhost:7918"
            serverPath: "http://localhost:46667"

        });
}());
