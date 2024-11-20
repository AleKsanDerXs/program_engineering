

#ifdef _WIN32
    #ifdef TEXT_OPERATIONS_EXPORTS
        #define DLL_EXPORT __declspec(dllexport)
    #else
        #define DLL_EXPORT __declspec(dllimport)
    #endif
#else
    #define DLL_EXPORT
#endif

#include <vector>
#include <string>

namespace TextLibrary {
    DLL_EXPORT std::string Meow(const std::string& str); 
}
