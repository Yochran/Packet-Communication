const Data = require("./data/data.json");
const Config = require("./config.json");

const Utils = require("./utils.js");
const Updater = require("./jsonupdater.js");

let S_DELAY = Config.S_DELAY;
let S_UNIT = Config.S_UNIT;

let JSON_CHECK_INTERVAL = Config.JSON_CHECK_INTERVAL;

startup(S_DELAY, S_UNIT);

function startup(d, u) {
    Utils.LOG_MSG("Starting up JS Index...");
    let R_UD;

    if (u === "SECONDS") {
        R_UD = d * 1000;
    } else if (u === "MILLISECONDS" || u === "MS") {
        R_UD = d;
    }

    if (!R_UD) {
        R_UD = d;
    }

    setTimeout(() => {
        Utils.LOG_MSG(`JS Index started up. (${R_UD} ${u.toLowerCase()})`);

        Updater.RUN_CHECKER(JSON_CHECK_INTERVAL, Data);
    }, R_UD);
}