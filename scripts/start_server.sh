#!/bin/bash
systemctl daemon-reload
systemctl start raghucloudapp.service
systemctl enable raghucloudapp.service