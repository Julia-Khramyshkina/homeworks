#-------------------------------------------------
#
# Project created by QtCreator 2014-06-15T13:52:24
#
#-------------------------------------------------

QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = gun
TEMPLATE = app

CONFIG += C++11
							 ^


SOURCES += main.cpp\
    gun.cpp \
    target.cpp \
    shell.cpp \
    mainWindow.cpp

HEADERS  += \
    gun.h \
    target.h \
    shell.h \
    mainWindow.h

FORMS    += mainwindow.ui
