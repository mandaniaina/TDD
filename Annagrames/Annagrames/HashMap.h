#pragma once
ref class HashMap
{
public:
	HashMap(int size);
	void add(const void *key, const void *value);
	const void *get(const void *key);
	virtual ~HashMap();
};

