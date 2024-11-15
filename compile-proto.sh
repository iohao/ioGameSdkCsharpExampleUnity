#!/bin/bash
protoc --csharp_out=./Assets/Scripts/Gen --proto_path=. ./proto/common.proto