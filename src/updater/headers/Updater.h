#pragma once

#include "Utils.h"

#include <iostream>
#include <string>
#include <stdlib.h>
#include <Windows.h>
#include <stdio.h>

class Updater {
private:
	Utils _Utils;
public:
	bool U_ISCHECKABLE(bool I_COMPLETION) {
		if (I_COMPLETION == true) {
			return true;
		}
		else {
			return false;
		}
	}

	void U_CHECK(bool I_COMPLETION) {
		if (!U_ISCHECKABLE(I_COMPLETION)) {
			system("color 0c");
			_Utils.U_PRINT("Updater is not complete, cannot run check.");
			system("pause");
		}
		else {
			_Utils.U_PRINT("Running check...");

			// When initial is complete, code checker below.
		}
	}
};

