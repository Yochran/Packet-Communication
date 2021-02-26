#include "Utils.h"
#include "Updater.h"

#include <iostream>
#include <stdlib.h>

Utils _Utils;
Updater _Updater;

bool M_COMPLETE = false;

int main()
{
    _Utils.M_STARTUP();

    _Utils.U_PRINT("\nChecking for updates...\n");

    Sleep(3000);
    _Updater.U_CHECK(M_COMPLETE);

    system("pause");
}
