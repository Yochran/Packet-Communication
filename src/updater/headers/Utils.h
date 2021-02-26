#pragma once

#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <Windows.h>
#include <string>

class Utils {
public:
	void U_PRINT(std::string I_MSG) {
		std::cout << I_MSG << std::endl;
	}

	std::string U_INPUT(std::string I_STR) {
		std::cin >> I_STR;

		return I_STR;
	}

	void M_STARTUP() {
		system("color 0b");
		system("title Packet Communicator v1.0 (Updater)");

		U_PRINT("Packet Communicator Updater has loaded.");
	}
};

