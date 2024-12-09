
#!/bin.bashh

if [ "$EUID" -ne 0]; then
	echo "This script must be run as root. run 'sudo !!'"
	exit 1
fi

echo "Running as root. Continuing with script ...."

chmod +x ./StartupScripts/*.sh

sudo rm /etc/systemd/system/run_teledyne_modem_test.service
sudo cp ./StartupScripts/run_teledyne_modem_test.service /etc/systemd/system/
sudo systemctl enable run_teledyne_modem_test.service
sudo reboot now


LINE_TO_ADD="bash $HOME/UnderwaterAcousticTracker/Teledyne/ExternalControl/StartupScripts/run_from_profile.sh"

if ! grep -Fxq "$LINE_TO_ADD" "$HOME/.profile"; then
	echo "Adding show script to ~/.profile..."
	echo "$LINE_TO_ADD" >> "$HOME/.profile"
else
	echo "Line is already present in ~/.profile"
fi
