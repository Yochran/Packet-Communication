const Data = require("./data/data.json");
const utils = require("./utils");

module.exports = {
    RUN_CHECKER: function(I_I, I_ORG) {
        setInterval(() => {
            const F_TC = Data.Accounts;

            if (JSON.stringify(F_TC) !== JSON.stringify(I_ORG["Accounts"])) {
                utils.LOG_MSG("data.json file was updated! Open to see changes.");
            }
        }, I_I);
    }
}