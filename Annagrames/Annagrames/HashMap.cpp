#include <unordered_map>
#include "HashMap.h"


std::unordered_map<const void *, const void *> htmap;
HashMap::HashMap(int size)
{
}

void HashMap::add(const void * key, const void * value)
{
	htmap[key] = value;
}

const void * HashMap::get(const void * key)
{
	return htmap[key];
}

HashMap::~HashMap()
{
}
