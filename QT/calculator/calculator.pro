#-------------------------------------------------
#
# Project created by QtCreator 2014-03-20T16:29:43
#
#-------------------------------------------------

QT       += core

QT       -= gui

TARGET = calculator
CONFIG   += console
CONFIG   -= app_bundle
CONFIG += C++11

TEMPLATE = app


SOURCES += main.cpp \
    stack.cpp \
    stackwitharray.cpp \
    generalstack.cpp \
    calculator.cpp

HEADERS += \
    stack.h \
    stackwitharray.h \
    generalstack.h \
    calculator.h
