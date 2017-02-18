#include "stdafx.h"
#include "../Annagrames/HashMap.h"

using namespace System;
using namespace System::Text;
using namespace System::Collections::Generic;
using namespace	Microsoft::VisualStudio::TestTools::UnitTesting;

namespace TestProjectAnnagrames
{
	[TestClass]
	public ref class HashMapTest
	{
	public: 
		[TestMethod]
		void AddAndFindCharTest()
		{
			char* test = "dsfg";
			HashMap map(100);
			map.add("test", test);
			char* found = (char*) map.get("test");
			Assert::AreEqual(test, found);
			Assert::AreEqual(2, 1);
		}
	};
}
