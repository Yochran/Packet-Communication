const fs = require("fs");

module.exports = {
    GET_CTIME: function() {
        const F_DATE = new Date();

        const MO = F_DATE.getMonth();
        const D = F_DATE.getDay();
        const Y = F_DATE.getFullYear();

        const M = F_DATE.getMinutes();
        const S = F_DATE.getSeconds();

        let time = `${MO}/${D}/${Y}, ${M}:${S}`

        return time;
    },

    LOG_MSG: function(msg) {
        const time = this.GET_CTIME();

        console.log(`[${time}] ${msg}`);

        let C_FDATA = fs.readFileSync("logs.txt", (err) => {
            if (err) {
                console.log(`[${time}] ERROR: Couldn't read from logs file. Creating one now...`);
                fs.writeFileSync("logs.txt", "----- [LOGS] -----\n", (err) => {
                    if (err) {
                        console.log(`[${time}] ERROR: Couldn't create logs file. Create one manually.`);
                    }
                });
            }
        });

        fs.writeFileSync("logs.txt", C_FDATA + `[${time}] ${msg}\n`, (err) => {
            if (err) {
                console.log("Couldn't write to logs file.");
            }
        });
    }
}